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


namespace Empresa_vehiculos
{
    
    public partial class Form_Alquileres : Form
    {
        List<Alquileres> alquileres = new List<Alquileres>();

        public Form_Alquileres()
        {
            InitializeComponent();
        }
       private void GuardarAlquileres()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var u in alquileres)
            {
                writer.WriteLine(u.Nit);
                writer.WriteLine(u.placa);
                writer.WriteLine(u.fechaAlquiler);
                writer.WriteLine(u.fechaDevolucion);
                writer.WriteLine(u.kilometros);

            }
            writer.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Alquileres alquiler = new Alquileres();
            alquiler.Nit = textBox1.Text;
            alquiler.placa = textBox2.Text;
            alquiler.fechaAlquiler = dateTimePicker1.Value;
            alquiler.fechaDevolucion = dateTimePicker2.Value;
            alquiler.kilometros = Convert.ToInt32(textBox3.Text);
            alquileres.Add(alquiler);
            GuardarAlquileres();
           
        }
    }
}
