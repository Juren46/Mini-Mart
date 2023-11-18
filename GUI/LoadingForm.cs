using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top -= 5;
            if (label1.Top <= 395)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Top += 5;
            if (label1.Top >= 415)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 13;
            if (panel2.Width >= 835)
            {
                timer3.Stop();

                TrangChuForm frm = new TrangChuForm();
                frm.Show();
                this.Hide();
            }
        }
    }
}
