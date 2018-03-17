using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Test22
{
    public partial class Form1 : Form
    {

        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void On_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("N");
            On_btn.Enabled = false;
            Off_btn.Enabled = true;

        }
        private void init()
        {
            try
            {

          
            }

            catch(Exception)
            {
                MessageBox.Show("Cannot ");
            }
            //
            On_btn.Enabled = true;
            Off_btn.Enabled = false;

        }

        private void Off_btn_click(object sender, EventArgs e)
        {
            myport.WriteLine("F");
            On_btn.Enabled = true;
            Off_btn.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 115200;
            myport.PortName = textBox1.Text;
            myport.Open();
        }

        private void On_btn2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("n");
            On_btn2.Enabled = false;
            Off_btn2.Enabled = true;
        }

        private void Off_btn2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("f");
            On_btn2.Enabled = true;
            Off_btn2.Enabled = false;
        }
    }
}
