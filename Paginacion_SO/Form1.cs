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
        List<Button> Mem = new List<Button>();
        int Pivote = 0;
        public int TamañoMemoria;
        public int TamañoPagina;
        public int Memoria_Aux;
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
                MessageBox.Show("El Tamaño de la pagina no puede ser mayor que la memoria principal");
            }

           
            for (int i = 0; i < tamano; i++)
            {
                Button b = new Button();
                b.Name = "b" + (i * tamano).ToString();
                b.Size = new Size(20, 60);
                b.BackColor = Color.Green;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.Black;
                b.Location = new Point((i*20)+25,180);
                this.Controls.Add(b);
                Mem.Add(b);
            }

            Tam.Text = Convert.ToString(TamañoMemoria)+ " MB";
            Tam_Pag.Text = Convert.ToString(TamañoPagina) + " MB";
            num_Pag.Text = Convert.ToString(tamano);
            Memoria_Aux = TamañoMemoria;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            button1.Enabled = false;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre_Proceso = Convert.ToString(textBox3.Text);
            Tamaño_Proceos = Convert.ToInt32(textBox4.Text);
            if (Memoria_Aux > Tamaño_Proceos)
            {
                string aux = richTextBox1.Text;
                richTextBox1.Text = aux + "El Proceso :" + Nombre_Proceso + " Requiere una Memoria de " + Tamaño_Proceos + "MB"  + "\n";
                Memoria_Aux = Memoria_Aux - Tamaño_Proceos;
            }
            else// (Memoria_Aux < Tamaño_Proceos)
            {
                string aux = richTextBox2.Text;
                richTextBox2.Text = aux + "El Proceso :" + Nombre_Proceso + " Requiere una Memoria de " + Tamaño_Proceos + "MB" + "\n";

            }

            if (Tamaño_Proceos > TamañoPagina && Pivote < tamano)
            {
                Pivote = Math.Abs(Tamaño_Proceos / TamañoPagina)  + Pivote;
                for (int i = 0; i < Pivote; i++)
                {
                    Mem[i].BackColor = Color.Yellow;
                }
            }
            //else

            if (Tamaño_Proceos < TamañoPagina)
            {
                Pivote = Pivote + 1;
                for (int i = 0; i < Pivote; i++)
                {
                    Mem[i].BackColor = Color.Yellow;
                }
            }

            //if (Pivote > tamano)
            //{
            //    string aux = richTextBox2.Text;
            //    richTextBox2.Text = aux + "El Proceso :" + Nombre_Proceso + " Requiere una Memoria de " + Tamaño_Proceos + "MB" + "\n";
            //}



        }





    }
}
