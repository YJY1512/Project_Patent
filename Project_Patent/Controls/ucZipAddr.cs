using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Patent
{
    public partial class ucZipAddr : UserControl
    {
        public string Addr1 
        { 
            get { return txtAddr1.Text; }        
            set { txtAddr1.Text = value; }
        }

        public string Addr2
        {
            get { return txtAddr2.Text; }
            set { txtAddr2.Text = value; }
        }

        public string Addr3
        {
            get { return txtAddr3.Text; }
            set { txtAddr3.Text = value; }
        }


        public ucZipAddr()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmZipSearchPopup pop = new frmZipSearchPopup();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtAddr1.Text = pop.ZipCode;
                txtAddr2.Text = pop.Addr1;
                txtAddr3.Text = pop.Addr2;

                txtAddr3.Focus();
            }
        }
    }
}
