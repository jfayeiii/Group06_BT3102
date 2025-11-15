using GOSO_Hotel.Controller;
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
    public partial class UserControlAdminCheckinCheckout : UserControl
    {
        public UserControlAdminCheckinCheckout()
        {
            InitializeComponent();
        }

        private void CheckOutbtn_Click(object sender, EventArgs e)
        {
            {
                if (!int.TryParse(CheckOutSearchtxt.Text, out int id))
                {
                    MessageBox.Show("Invalid Customer ID.");
                    return;
                }

                var manager = new CheckInOutController();
                string result = manager.CheckOut(id);

                MessageBox.Show(result);
            }
        }
    }
}
