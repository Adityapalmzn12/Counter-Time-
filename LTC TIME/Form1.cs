using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LTC_TIME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            string aditya = "LTC TIME : " + DateTime.Now.ToString("hh:mm:ss:fff");
            string[] element = Regex.Split(aditya, ":");
            int x = Convert.ToInt16(element[4]);
            x = x / 40;
             string ashu = "LTC TIME : " + DateTime.Now.ToString("hh:mm:ss");
            label1.Text=  ashu +":" +x;
        }
    }
}
