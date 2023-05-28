using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private int counter;
        int liczbaPierwsza;
        int liczbaDruga;
        int score = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            wynik.KeyDown += new KeyEventHandler(tb_KeyDown);
        }
       
        private void startbutton_Click(object sender, EventArgs e)
        {
            counter = 30;
            timer1.Start();
            timer.Text = counter.ToString();
            losujLiczby();
            startbutton.Enabled = false;
            score = 0;
            scoreLabel.Text = score.ToString();
        }
        

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (liczbaPierwsza + liczbaDruga == int.Parse(wynik.Text))
                {
                    Console.WriteLine("POPRWANIE");
                    losujLiczby();
                    wynik.Text = "";
                    score += 1;
                    scoreLabel.Text = score.ToString(); 
                }
                else
                {
                    Console.WriteLine("JESTESGUPI\n\nJAKBUT");
                }
            }
        }

        private void losujLiczby()
        {
            liczbaPierwsza = rnd.Next(1,20);
            liczbaDruga = rnd.Next(1,20);
            liczba1.Text = $"{liczbaPierwsza}";
            liczba2.Text = $"{liczbaDruga}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("KONIEC\nCZASU");
                startbutton.Enabled = true;
            }
            timer.Text = counter.ToString();
        }

        
    }
}
