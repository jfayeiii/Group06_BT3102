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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginfdbtn_Click(object sender, EventArgs e)
        {
            FrontDeskForm fdform = new FrontDeskForm();
            fdform.Show();
           
        }

        private void loginadminbtn_Click(object sender, EventArgs e)
        {
            AdminForm adform = new AdminForm();
            adform.Show();
        }

       
    }
}
