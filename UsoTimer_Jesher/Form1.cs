using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoTimer_Jesher
{
    public partial class Form1 : Form
    {
        Int32 isegundos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblExibe.Text = DateTime.Now.ToString();
            isegundos++;
            TimeSpan t = TimeSpan.FromSeconds(isegundos);

            string stempo = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);

            lblTempo.Text = stempo;            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lblExibe.Text = DateTime.Now.ToString();
            btnoff.Visible = false;
        }

        private void Btnon_Click(object sender, EventArgs e)
        {
            //timer01.Enabled = true;

            //Método para ativar e desativar com um mesmo botão
            timer01.Enabled = !timer01.Enabled;
            if (timer01.Enabled == false)
            { 
                btnon.Text = "Ligar";
                isegundos = 0;
            }
            else btnon.Text = "Desligar";
        }

        private void Btnoff_Click(object sender, EventArgs e)
        {
            timer01.Enabled = false;
        }
    }
}
