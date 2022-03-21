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
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos= new List<Vehiculo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarVehiculos()
        {
            FileStream stream = new FileStream("Vehiculo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var u in vehiculos)
            {
                writer.WriteLine(u.Placa);
                writer.WriteLine(u.Modelo);
                writer.WriteLine(u.Marca);
                writer.WriteLine(u.Color);
                writer.WriteLine(u.PrecioKilometro);
            }
            writer.Close();
        }

        private void ButtonIngreso_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = textplaca.Text;
            vehiculo.Modelo = Convert.ToInt16(textmodelo.Text);
            vehiculo.Marca=textmarca.Text;
            vehiculo.Color = textcolor.Text;
            vehiculo.PrecioKilometro = Convert.ToDecimal (textpreciok.Text);

            int ps = vehiculos.FindIndex(x => x.Placa == vehiculo.Placa);
            if (ps == -1)
            {
                vehiculos.Add(vehiculo);
                GuardarVehiculos();
            }
            else
            {
                MessageBox.Show("Placa repetida");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Alquileres form = new Form_Alquileres();
            form.Show();
        }
    }
}
