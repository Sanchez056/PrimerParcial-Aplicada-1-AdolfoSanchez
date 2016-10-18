using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace PrimerParcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
                LLenar(ClientesBLL.Buscar(StringToInt(ClienteIdtextBox.Text)));

        }
        private void LLenar(Clientes clientes)
        {

            ClienteIdtextBox.Text = clientes.ClienteId.ToString();
            NombretextBox.Text = clientes.Nombre;
            FechaNacimientotextBox.Text = clientes.FechaNacimiento;
            LimiteCreditotextBox.Text = clientes.LimiteCredito.ToString();
          
        }
       
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(StringToInt(ClienteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            
                LlenarClase(cliente);
                ClientesBLL.Insertar(cliente);
              
                MessageBox.Show("Guardado con exito");
            }
        private void LlenarClase(Clientes c)
        {
            c.Nombre = NombretextBox.Text;
            c.FechaNacimiento= FechaNacimientotextBox.Text;
            c.LimiteCredito = int.Parse(LimiteCreditotextBox.Text);

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (ValidarBuscar())
            {
                ClientesBLL.Eliminar(StringToInt(ClienteIdtextBox.Text));
                
                MessageBox.Show("ELiminado con exito");
            }
        }
        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombretextBox.Clear();
            FechaNacimientotextBox.Clear();
            LimiteCreditotextBox.Clear();
        }
        private void Modificarbutton_Click(object sender, EventArgs e)
        {

        }
    }
    }

