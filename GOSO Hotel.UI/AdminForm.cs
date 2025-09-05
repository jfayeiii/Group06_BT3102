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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void loginAdminbtn_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrWhiteSpace(adminusertxt.Text.ToString()) || string.IsNullOrWhiteSpace(adminpasstxt.Text.ToString()))
            {
                MessageBox.Show("Fields cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!string.IsNullOrWhiteSpace(adminusertxt.Text.ToString()) || !string.IsNullOrWhiteSpace(adminpasstxt.Text.ToString()))
            {
                MessageBox.Show("Login Success");

                AdminDashboard adDash = new AdminDashboard();
                adDash.Show();
                this.Hide();

                MessageBox.Show("Login Success");
            }
        }
    }
}
