using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        public Int32 la = 1;
        public Form1()
        {
            InitializeComponent();
        }
        public string godzina, minuta, sekunda, milisekunda;
        public StreamWriter elomili = new StreamWriter("elo.txt");
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
           DateTime elo=DateTime.Now;
           elomili.WriteLine(elo.Millisecond);

           HOURS.Value = elo.Hour;
           MINUTES.Value = elo.Minute;
           SECONDS.Value = elo.Second;
           MILISECONDS.Value = elo.Millisecond;
           YEARS.Value = elo.Year;
           MONTHS.Value = elo.Month;
           DAYS.Value = elo.Day;
           textBox1.AppendText(elo.Millisecond.ToString() + "\n");
           zera();
           hprzyp.Text = godzina + ":" + minuta + ":" + sekunda + ":" + milisekunda;
           wyswgodzina();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime elo = DateTime.Now;
            hprzyp.Text = godzina + ":" + minuta + ":" + sekunda + ":" + milisekunda;
        }
        public void zera()
        {
            DateTime hh=DateTime.Now;
            if (HOURS.Value > 9)
            {
                godzina =hh.Hour.ToString();
            }
            if (HOURS.Value < 10)
            {
                godzina = "0" + hh.Hour.ToString();
            }
            if (MINUTES.Value > 9)
            {
                minuta =hh.Minute.ToString();
            }
            if (MINUTES.Value < 10)
            {
                minuta = "0" + hh.Minute.ToString();
            }
            if (SECONDS.Value > 9)
            {
                sekunda =hh.Second.ToString();
            }
            if (SECONDS.Value < 10)
            {
                sekunda = "0" + hh.Second.ToString();
            }
            if (MILISECONDS.Value > 99)
            {
                milisekunda =hh.Millisecond.ToString();
            }
            if (MILISECONDS.Value > 9&&MILISECONDS.Value<100)
            {
                milisekunda = "0"+hh.Millisecond.ToString();
            }
            if (MILISECONDS.Value < 10)
            {
                milisekunda = "00"+hh.Millisecond.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "stop")
            {
                timerDateTime.Stop();
                timer1.Stop();
                button1.Text = "start";
            }
            else
                if (button1.Text == "start")
                {
                    timer1.Start();
                    timerDateTime.Start();
                    button1.Text = "stop";
                }
        }
        public void wyswgodzina()
        {
            DateTime elo =DateTime.Now;
            label3.Text = HOURS.Value.ToString();
            label5.Text = MINUTES.Value.ToString();
            label6.Text = SECONDS.Value.ToString();
            label7.Text = MILISECONDS.Value.ToString();
            rok.Text = YEARS.Value.ToString();
            miesiac.Text = MONTHS.Value.ToString();
            dzien.Text = DAYS.Value.ToString();
            tydzien.Text = elo.DayOfWeek.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            elomili.Close();
        }
    }
}
