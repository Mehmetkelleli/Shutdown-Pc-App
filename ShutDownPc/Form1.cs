using System.Configuration;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShutDownPc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tm = timer.Text.ToString().Split(":");
            var second = int.Parse(tm[2]);
            var minu = int.Parse(tm[1]);
            var hr = int.Parse(tm[0]);
            if (hr == 0 && second == 0 && minu == 0)
            {
                timer1.Stop();
            }
            else
            {
                if (second > 0)
                {
                    second--;
                }
                else
                {
                    second = 59;
                    if (minu > 0)
                    {
                        minu--;
                    }
                    else
                    {
                        minu = 59;
                        if (hr > 0)
                        {
                            hr--;
                        }
                    }
                }


                timer.Text = $"{hr}:{minu}:{second}";
                if(timer.Text == "0:0:0")
                {
                    Process.Start("shutdown.exe", "-s -t 00");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var time = timer.Text.Trim();
            timer.Text = $"{hour.Text}:{Minute.Text}:0";

            if (timer.Text == "0:0:0")
            {
                MessageBox.Show("Time Create");
                return;
            }
            timer1.Enabled = true;
        }
    }
}