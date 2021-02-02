using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multithreading_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Do time Consuming Work button

            //button1.Enabled = false;
            //button2.Enabled = false;

            Thread backGroundThread = new Thread(DotimeComsummingWork);

            //DotimeComsummingWork();

            button1.Enabled = true;
            button2.Enabled = true;

        }

        private void DotimeComsummingWork()
        {
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //print Number button
            for(int i=1; i<= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }

    }
}
