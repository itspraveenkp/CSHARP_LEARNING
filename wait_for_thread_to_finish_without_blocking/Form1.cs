using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace wait_for_thread_to_finish_without_blocking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int countCharacter()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\data\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() => 
            { 
                count = countCharacter();
                Action action = () => lblcount.Text = count.ToString() + " Characters in file";
                this.BeginInvoke(action);
            });
            thread.Start();

            lblcount.Text = "Processing File Please wait....";

        }
    }
}
