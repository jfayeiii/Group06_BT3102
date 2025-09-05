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
        public FrontDeskForm()
        {
            InitializeComponent();
        }


        private void loginfdbtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fdusertxt.Text.ToString()) || string.IsNullOrWhiteSpace(fdpasstxt.Text.ToString()))
            {
                MessageBox.Show("Fields cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(!string.IsNullOrWhiteSpace(fdusertxt.Text.ToString()) || !string.IsNullOrWhiteSpace(fdpasstxt.Text.ToString()))
            {
                FronDeskDashboard fdDash = new FronDeskDashboard();
                fdDash.Show();
                this.Hide();

                MessageBox.Show("Login Success");
            }
        }
    }
}
