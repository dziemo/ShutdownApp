using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dodajGodzine_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
        }

        private void dodajGodziny_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + 10).ToString();
        }

        private void odejmijGodzine_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
        }

        private void odejmijGodziny_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) >= 10)
                textBox1.Text = (Convert.ToInt32(textBox1.Text) - 10).ToString();
        }

        private void dodajMinuty_Click(object sender, EventArgs e)
        {
           textBox2.Text = (Convert.ToInt32(textBox2.Text) + 5).ToString();
            if ((Convert.ToInt32(textBox2.Text) > 59))
            {
                textBox2.Text = ((Convert.ToInt32(textBox2.Text) - 60)).ToString();
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
            }
        }

        private void dodajMinute_Click(object sender, EventArgs e)
        {
           textBox2.Text = (Convert.ToInt32(textBox2.Text) + 10).ToString();
           if ((Convert.ToInt32(textBox2.Text) > 59))
           {
               textBox2.Text = ((Convert.ToInt32(textBox2.Text) - 60)).ToString();
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
           }
        }

        private void odejmijMinute_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) >= 5)
                textBox2.Text = (Convert.ToInt32(textBox2.Text) - 5).ToString();
        }

        private void odejmijMinuty_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) >= 10)
                textBox2.Text = (Convert.ToInt32(textBox2.Text) - 10).ToString();
        }

        private void odliczaj_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(textBox1.Text) * 3600, m = Convert.ToInt32(textBox2.Text) * 60;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown /s /t " + (h + m).ToString();
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown /a";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
