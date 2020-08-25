using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nohejbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            RozlosovaniHracu();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RozlosovaniHracu()
        {
            List<string> Tym1 = new List<string>();
            List<string> Tym2 = new List<string>();
            List<string> Tym3 = new List<string>();
            List<string> Tym4 = new List<string>();

      
            List<string> hraci = new List<string>();
            if (checkBox1.Checked)
                hraci.Add(checkBox1.Text);
            if (checkBox2.Checked)
                hraci.Add(checkBox2.Text);
            if (checkBox3.Checked)
                hraci.Add(checkBox3.Text);
            if (checkBox4.Checked)
                hraci.Add(checkBox4.Text);
            if (checkBox5.Checked)
                hraci.Add(checkBox5.Text);
            if (checkBox6.Checked)
                hraci.Add(checkBox6.Text);
            if (checkBox7.Checked)
                hraci.Add(checkBox7.Text);
            if (checkBox8.Checked)
                hraci.Add(checkBox8.Text);
            if (checkBox9.Checked)
                hraci.Add(checkBox9.Text);
            if (checkBox10.Checked)
                hraci.Add(checkBox10.Text);
            if (checkBox11.Checked)
                hraci.Add(checkBox11.Text);
            if (checkBox12.Checked)
                hraci.Add(checkBox12.Text);

            List<string> zamichat = hraci.OrderBy(a => Guid.NewGuid()).ToList();


            /* int ranTym1 = random.Next(hraci.Count); 
             int ranTym2 = random.Next(hraci.Count);
             int ranTym3 = random.Next(hraci.Count);
             int ranTym4 = random.Next(hraci.Count);
             */

                /*Tym1.Add(zamichat[0]);
                Tym1.Add(zamichat[1]);
                Tym1.Add(zamichat[2]);

                Tym2.Add(zamichat[3]);
                Tym2.Add(zamichat[4]);
                Tym2.Add(zamichat[5]);

                Tym3.Add(zamichat[6]);
                Tym3.Add(zamichat[7]);
                Tym3.Add(zamichat[8]);

                Tym4.Add(zamichat[9]);
                Tym4.Add(zamichat[10]);
                Tym4.Add(zamichat[11]);
                */


            for(int i=0;i<hraci.Count;i++)
            {
                double pocettymu =Math.Ceiling(Convert.ToDouble(zamichat.Count)/3) ;                           //tady na tom radku musime zjistit kolik bude tymu
                double x =( i % (pocettymu));
                if (x == 0)
                    Tym1.Add(zamichat[i]);
                if (x ==1)
                    Tym2.Add(zamichat[i]);
                if (x == 2)
                    Tym3.Add(zamichat[i]);
                if (x == 3)
                    Tym4.Add(zamichat[i]);
            }















            textBox1.Text = string.Join(",", Tym1);
            textBox2.Text = string.Join(",", Tym2);
            textBox3.Text = string.Join(",", Tym3);
            textBox4.Text = string.Join(",", Tym4);










        }
    }
}
