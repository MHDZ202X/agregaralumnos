using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("C:\\Users\\DELL LATITUDE\\Desktop\\alumnos", true);
            escribir.WriteLine("NOMBRE: " + textBox1.Text);
            escribir.WriteLine("APELLIDO: " + textBox2.Text);
            escribir.WriteLine("MATRICULA: " + textBox3.Text);
            escribir.WriteLine("TELEFONO: " + textBox4.Text);
            escribir.WriteLine("\n");
            escribir.Close();
            MessageBox.Show("datos guardados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader("C:\\Users\\DELL LATITUDE\\Desktop\\alumnos");
            string linea;
            linea = leer.ReadLine();
            while (linea != null)
            {
                richTextBox1.AppendText(linea + "\n");
                linea = leer.ReadLine();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
        }
    }
}
