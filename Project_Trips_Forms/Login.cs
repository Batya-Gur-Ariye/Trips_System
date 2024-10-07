using Newtonsoft.Json;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Password.Visible = true;
            UserName.Visible = true;
            enterBtn.Visible = true;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string baseUrl = "https://localhost:7259/api/Users/";
                WebApiUtils w = new WebApiUtils(baseUrl);
                string r = w.Invoke("Login?", $"userName={UserName.Text}&password={Password.Text}");

                if (!string.IsNullOrEmpty(r))
                {
                    User user = JsonConvert.DeserializeObject<User>(r);
                    if (user.IsAdmin)
                    {
                        Managment managmentScreen = new Managment(user);
                        managmentScreen.Show();
                        managmentScreen.Focus();
                    }
                    else
                    {
                        UserScreen userScreen = new UserScreen(user);
                        userScreen.Show();
                        userScreen.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The password or user name isn't valid!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Password.Visible = false;
            UserName.Visible = false;
            enterBtn.Visible = false;
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
