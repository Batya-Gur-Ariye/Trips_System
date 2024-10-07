
using AutoMapper;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_Trips_Core.ModelDto;
using Project_Trips_Core.Services;
using Project_Trips_Data.Migrations;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using User = Project_Trips_Data.Models.User;

namespace Project_Trips_Forms
{
    public partial class UserScreen : Form
    {
        private readonly IMapper _mapper;
        private User _user;
        public UserScreen(User user)
        {
            _user = user;
            InitializeComponent();
            LabelName.Text = user.FirstName + " " + user.LastName;
            init();
        }

        public void init()
        {
            try
            {
                string baseUrl = "https://localhost:7259/api/Trips/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                string r = w.Invoke("GetFutureTrips", "");

                if (!string.IsNullOrEmpty(r))
                {
                    List<TripDto> l = JsonConvert.DeserializeObject<List<TripDto>>(r).ToList();
                    ShowTrips.DataSource = l;
                    ShowTrips.Columns["TripId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string baseUrl = "https://localhost:7259/api/Orders/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                string r = w.Invoke("GetOrdersByUserId?", $"userId={_user.UserId}");

                if (!string.IsNullOrEmpty(r))
                {
                    List<GetOrderWithTripDetails> l = JsonConvert.DeserializeObject<List<GetOrderWithTripDetails>>(r).ToList();
                    MyOrdersDGV.DataSource = l;
                }
                else
                {
                    MessageBox.Show("the list is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowAllTrips_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedTrip = ShowTrips.SelectedRows[0];
                if (selectedTrip != null)
                {
                    OrderDto order = new OrderDto()
                    {
                        Createdate = DateTime.Today,
                        TripId = Convert.ToInt32(selectedTrip.Cells["TripId"].Value),
                        UserId = _user.UserId,
                        Status = ((eStatusOrder)selectedTrip.Cells["Status"].Value)
                    };

                    JObject jo = JObject.FromObject(order);
                    string baseUrl = "https://localhost:7259/api/Orders/";
                    WebApiUtils w = new WebApiUtils(baseUrl);
                    string r = w.InvokeByMethod(Methods.POST, "AddOrder?", jo);
                    bool succ = JsonConvert.DeserializeObject<bool>(r);
                    if (!string.IsNullOrEmpty(r) && succ == true)
                    {
                        MessageBox.Show("the order has been added successfully :)");
                        init();
                    }
                    else
                    {
                        MessageBox.Show("action failed, try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("please, select trip");
            }

        }

        private void ShowMyOrders_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_user_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
        }

        private void ShowTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
