using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer t;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value >= 10)
            {
                t.Stop();
                label1.Text = "Таймер загружен";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            progressBar1.Maximum = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
