using ABMdotNet.Controller;
using ABMdotNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMdotNet.View
{
    public partial class AddClientsView : Form
    {
        public AddClientsView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre = textBoxNombre.Text;
            string Apellido = textBoxApellido.Text;
            string Email = textBoxEmail.Text;
            string Direccion = textBoxDireccion.Text;
            string Telefono = textBoxTelefono.Text;
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) || string.IsNullOrEmpty(Email))
            {
                clearAndShowMessage("Los campos Nombre, Apellido y Emial deben estar cargados");
            }
            try
            {                
                Client client = new Client();
                client.Nombre = Nombre;
                client.Apellido = Apellido;
                client.Email = Email;
                client.Direccion = Direccion;
                client.Telefono = Telefono;
                ClientController Controller = new ClientController();
                if (Controller.insertClient(client))
                {
                    MessageBox.Show("Cliente insertado correctamente");
                    this.Close();
                }
                else
                {
                    clearAndShowMessage("El cliente no fue insertado");
                }
            }
            catch (Exception ex)
            {
                clearAndShowMessage("Ocurrió un error: " + ex);
            }
        }

        private void clearAndShowMessage(string message)
        {
            MessageBox.Show(message);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEmail.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
        }
    }
}
