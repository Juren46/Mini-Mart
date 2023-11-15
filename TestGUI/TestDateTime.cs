using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class TestDateTime : Form
    {
        public TestDateTime()
        {
            InitializeComponent();
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy";
            guna2DateTimePicker1.ShowCheckBox = true;
            guna2DateTimePicker1.Checked = false;
        }

        private void guna2DateTimePicker1_MouseUp(object sender, MouseEventArgs e)
        {
            if (guna2DateTimePicker1.Checked)
            {
                guna2TextBox1.Text = guna2DateTimePicker1.Value.ToString();
            }
            if (!guna2DateTimePicker1.Checked)
            {
                guna2TextBox1.Text = "";
            }
        }
    }
}
