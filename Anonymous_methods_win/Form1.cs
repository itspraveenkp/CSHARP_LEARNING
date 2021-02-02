using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymous_methods_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "ClickMe";
            button1.Click += new EventHandler(Button_Click);
            this.Controls.Add(button1);
        }

        public void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }
    }
}
