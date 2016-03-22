using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paginacion_SO
{
    public partial class Form1 : Form
    {
        public int TamañoMemoria;
        public int TamañoPagina;

        public string Nombre_Proceso;
        public int Tamaño_Proceos;
        public int tamano;
        //public string[] Procesos;
        
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            TamañoMemoria = Convert.ToInt32(textBox1.Text);
            TamañoPagina = Convert.ToInt32(textBox2.Text);
            if (TamañoMemoria > TamañoPagina)
            {
                tamano = Math.Abs(TamañoMemoria / TamañoPagina);
            }
            if (TamañoMemoria < TamañoPagina)
            {
                MessageBox.Show("El Tamaño de la pagina ni puede ser mayor que la memoria principal");
            }

           
            for (int i = 0; i < tamano; i++)
            {
                Button b = new Button();
                b.Name = "b" + (i * tamano).ToString() + (500).ToString();
                b.Size = new Size(20, 60);
                b.BackColor = Color.Green;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.Black;
                b.Location = new Point((i*20)+25,180);
                this.Controls.Add(b);
            }

            Tam.Text = Convert.ToString(TamañoMemoria)+ " MB";
            Tam_Pag.Text = Convert.ToString(TamañoPagina) + " MB";
            num_Pag.Text = Convert.ToString(tamano);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre_Proceso = Convert.ToString(textBox3.Text);
            Tamaño_Proceos = Convert.ToInt32(textBox4.Text);



        }
    }
}
