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
    public partial class FrontDeskForm : Form
    {
        private UserController _userController;

        public FrontDeskForm()
        {
            InitializeComponent();
            this._userController = new UserController();
        }


        private void loginfdbtn_Click_1(object sender, EventArgs e)
        {
            string frontDeskUsername = fdusertxt.contentTextField.Text;
            string frontDeskPassword = fdpasstxt.contentTextField.Text;

            if (string.IsNullOrWhiteSpace(frontDeskUsername) || string.IsNullOrWhiteSpace(frontDeskPassword))
            {
                MessageBox.Show("Fields cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    UserModel matchingUser = _userController.ValidateUser(frontDeskUsername, frontDeskPassword, false);
                    if (matchingUser != null)
                    {
                        FronDeskDashboard frontDeskDashboard = new FronDeskDashboard();
                        frontDeskDashboard.ShowDialog();
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
