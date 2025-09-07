using GOSO_Hotel.Controller;
using GOSO_Hotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOSO_Hotel.UI
{
    public partial class AdminForm : Form
    {
        private UserController _userController;

        public AdminForm()
        {
            InitializeComponent();
            this._userController = new UserController();
        }

        private void loginAdminbtn_Click(object sender, EventArgs e)
        {
            string adminUsername = adminusertxt.contentTextField.Text;
            string adminPassword = adminpasstxt.contentTextField.Text;

            if (string.IsNullOrWhiteSpace(adminUsername) || string.IsNullOrWhiteSpace(adminPassword))
            {
                MessageBox.Show("Fields cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    UserModel matchingUser = _userController.ValidateUser(adminUsername, adminPassword, true);
                    if (matchingUser != null)
                    {
                        AdminDashboard adDash = new AdminDashboard();
                        adDash.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Invalid Credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
