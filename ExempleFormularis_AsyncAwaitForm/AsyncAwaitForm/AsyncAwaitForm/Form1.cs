using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btMentres.Enabled = false;
            listBox1.Enabled = false;
            textInicial.Visible = false;
            textFinal.Visible = false;
        }

        private void textDemano_TextChanged(object sender, EventArgs e)
        {

        }

        private async void  Btclica_Click(object sender, EventArgs e)
        {
            Cambrer cambrer = new Cambrer();
            var start = DateTime.Now;
            textInicial.Visible = true;
            textInicial.Text = start.ToString();
            var task = cambrer.ServirCervesa(textDemano.Text);
            task.Start();
            btMentres.Enabled = true;
            var cervesa = await task;
            start = DateTime.Now;
            textFinal.Visible = true;
            textFinal.Text = start.ToString() + " I em porten la meva " + cervesa.Nom;
            textDemano.Text = String.Empty;
            btMentres.Enabled = false;
            listBox1.Enabled = false;
        }

        private async void btMentres_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;

            string conversa = await Parlant();
            listBox1.Items.Add(conversa);
        }

        private Task <string> Parlant()
        {
            Task<string> t = Task.Run(() =>
            {
                return ("Parlant amb els amics");

            });
            
            return t;
        }
        
    }
}
