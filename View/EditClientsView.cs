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
    public partial class EditClientsView : Form
    {
        public EditClientsView()
        {
            InitializeComponent();
        }
        public EditClientsView(string nombre, string apellido, string email, string telefono, string direccion)
        {
            InitializeComponent();
            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
            textBoxEmail.Text = email;
            textBoxTelefono.Text = telefono;
            textBoxDireccion.Text = direccion;
        }        

        private void EditClientsView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientController Controller = new ClientController();
            Client client = new Client();
            client.Nombre = textBoxNombre.Text;
            client.Apellido = textBoxApellido.Text;
            client.Email = textBoxEmail.Text;
            client.Telefono = textBoxTelefono.Text;
            client.Direccion = textBoxDireccion.Text;

            if (Controller.updateClient(client))
            {
                MessageBox.Show("Cliente actualizado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
