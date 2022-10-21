using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            DateTime datum = dtpDatum.Value;
            DateTime vrijeme = dtpVrijeme.Value;

            StringBuilder ispis = new StringBuilder();
            ispis.Append("Vaš datum leta je: \r\n" + datum.ToShortDateString()+ "\r\n");
            ispis.Append("Vaše vrijeme polaska je: \r\n" + vrijeme.ToShortTimeString() + "\r\n");
            
            txtIspis.Text = ispis.ToString(); 
        }

        private void txtIspis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
