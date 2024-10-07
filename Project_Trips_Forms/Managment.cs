using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Trips_Forms
{
    public partial class Managment : Form
    {
        User user;
        public Managment(User user1)
        {
            InitializeComponent();
            this.user = user1;
            NameLabel.Text = this.user.FirstName + " " + this.user.LastName;
            status.DataSource = Enum.GetValues<eStatusTrip>();
            init();
        }

        private void init()
        {
            try
            {
                string baseUrl = "https://localhost:7259/api/Trips/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                string r = w.Invoke("GetAll", "");

                if (!string.IsNullOrEmpty(r))
                {
                    List<TripDto> l = JsonConvert.DeserializeObject<List<TripDto>>(r).ToList();
                    AllTripsDGV.DataSource = l;
                    AllTripsDGV.Columns["TripId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
             
        private void OrderPerTrip_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataGridView = AllTripsDGV.SelectedRows[0];
                int TripId = Convert.ToInt32(dataGridView.Cells["TripId"].Value);

                string baseUrl = "https://localhost:7259/api/Orders/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                string r = w.Invoke("getOrdersWithUserDataByTripId?", $"tripId={TripId}");

                if (!string.IsNullOrEmpty(r))
                {
                    List<OrderWithUserDetails> l = JsonConvert.DeserializeObject<List<OrderWithUserDetails>>(r).ToList();
                    OrderPerTripDGV.DataSource = l;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, select trip.");
            }
        }
        private void ShowAllTrips_Click(object sender, EventArgs e)
        {
            
        }
        private void ShowElements()
        {
            NameTrip.Visible = true;
            description.Visible = true;
            status.Visible = true;
            startdate.Visible = true;
            endDate.Visible = true;
            NumParticipants.Visible = true;
            lblStartDt.Visible = true;
            lblEndDt.Visible = true;
        }

        private void HideElements()
        {
            NameTrip.Visible = false;
            NameTrip.Text = "";
            description.Visible = false;
            description.Text = "";
            status.Visible = false;
            status.Text = "";
            startdate.Visible = false;
            startdate.Value = DateTime.Today;
            endDate.Visible = false;
            endDate.Value = DateTime.Today;
            NumParticipants.Visible = false;
            NumParticipants.Text = "";
            submitAddOrder.Visible = false;
            submitUpdateTrip.Visible = false;
            lblStartDt.Visible = false;
            lblEndDt.Visible = false;
        }
        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            ShowElements();
            submitAddOrder.Visible = true;
        }

        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            if (AllTripsDGV.SelectedRows.Count > 0)
            {
                ShowElements();            
                submitUpdateTrip.Visible = true;
                DataGridViewRow selectedRow = AllTripsDGV.SelectedRows[0];
                NameTrip.Text = selectedRow.Cells["Name"].Value.ToString();
                description.Text = selectedRow.Cells["Description"].Value.ToString();
                startdate.Text = selectedRow.Cells["StartDate"].Value.ToString();
                endDate.Text = selectedRow.Cells["EndDate"].Value.ToString();
                status.Text = selectedRow.Cells["Status"].Value.ToString();
                NumParticipants.Text = selectedRow.Cells["NumOfParticipants"].Value.ToString();
            }
            else
            {
                MessageBox.Show("please, choose the trip that you want to update & click again.");
            }
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string baseUrl = "https://localhost:7259/api/Trips/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                TripDto trip = new TripDto()
                {
                    Name = NameTrip.Text,
                    Description = description.Text,
                    Status = (eStatusTrip)status.SelectedIndex,
                    NumOfParticipants = Convert.ToInt32(NumParticipants.Text),
                    StartDate = Convert.ToDateTime(startdate.Text),
                    EndDate = Convert.ToDateTime(endDate.Text),
                    UserId = user.UserId
                };
                string s = JsonConvert.SerializeObject(trip);
                JObject t = JObject.FromObject(trip);
                bool succ = false;
                string r = w.InvokeByMethod(Methods.POST, "AddTrip?", t);
                if (!string.IsNullOrEmpty(r))
                {
                    succ = JsonConvert.DeserializeObject<bool>(r);
                    if (succ)
                        MessageBox.Show("the trip has been added succesfully");
                }
                HideElements();
                init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submitUpdateTrip_Click(object sender, EventArgs e)
        {
            try
            {
                string baseUrl = "https://localhost:7259/api/Trips/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                TripDto trip = new TripDto()
                {
                    Name = NameTrip.Text,
                    Description = description.Text,
                    Status = (eStatusTrip)status.SelectedItem,
                    NumOfParticipants = Convert.ToInt32(NumParticipants.Text),
                    StartDate = Convert.ToDateTime(startdate.Text),
                    EndDate = Convert.ToDateTime(endDate.Text),
                    UserId = user.UserId

                };
                string s = JsonConvert.SerializeObject(trip);
                JObject t = JObject.FromObject(trip);
                bool succ = false;
                string r = w.InvokeByMethod(Methods.PUT, "UpdateTrip?", t);
                if (!string.IsNullOrEmpty(r))
                {
                    succ = JsonConvert.DeserializeObject<bool>(r);
                    if (succ)
                        MessageBox.Show("the trip has been updated succesfully");
                }
                HideElements();
                init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderPerTripDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}



