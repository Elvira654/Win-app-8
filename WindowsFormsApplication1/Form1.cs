using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Blue;
            label1.Text = "Osnovne promjene";
            label1.Location = new Point(90, 110);
            label1.Height = 40;
            label1.Width = 300;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
