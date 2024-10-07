
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Trips_Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {

            try
            {

                string baseUrl = "https://localhost:7259/api/Users/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                User user = new User()
                {
                    Email = EaTXt.Text,
                    FirstName = FnTXt.Text,
                    LastName = LnTXt.Text,
                    UserId = idTXt.Text,
                    Password = passTxt.Text,
                    PhoneNumber = PnTXt.Text,
                    UserName = UserNameTxt.Text,
                    IsAdmin = (bool)IsAdminCb.SelectedItem
                };

                if (PassManTxt.Text == "TMS379" || (bool)IsAdminCb.SelectedItem == false)
                {
                    string s = JsonConvert.SerializeObject(user);
                    JObject t = JObject.FromObject(user);
                    bool succ = false;
                    string r = w.InvokeByMethod(Methods.POST, "AddUser?", t);
                    if (!string.IsNullOrEmpty(r))
                    {
                        succ = JsonConvert.DeserializeObject<bool>(r);
                        if (succ)
                            MessageBox.Show("you are successfully registered to our system :)\n" +
                                "now you can back to the login screen by clicking the down arrow & enter with your new details.");
                    }
                    else
                        MessageBox.Show("action failed, try again");
                }

                else
                    MessageBox.Show("Wrong manager password!!\ntry again or change to False.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IsAdminCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((bool)IsAdminCb.SelectedItem)
                PassManTxt.Visible = true;
            else
            {
                PassManTxt.Visible = false;
                PassManTxt.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
        }
    }
}
