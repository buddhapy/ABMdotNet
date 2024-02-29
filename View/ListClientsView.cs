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
    public partial class ListClientsView : Form
    {
        public ListClientsView()
        {
            InitializeComponent();
            ClientController Controller = new ClientController();
            List<Client> Clients = Controller.getClients();
            if (Clients.Count == 0)
            {
                MessageBox.Show("No se encuentran clientes registrados para mostrar");
            }
            else
            {
                dataGridViewClients.Rows.Clear();
                for (int i = 0; i < Clients.Count; i++)
                {
                    dataGridViewClients.Rows.Add(Clients[i].Nombre, Clients[i].Apellido, Clients[i].Email, Clients[i].Telefono, Clients[i].Direccion);
                }
            }
        }

        private void ListClientsView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en el encabezado de la columna)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewClients.Rows[e.RowIndex];

                // Acceder a los valores de las celdas en la fila seleccionada
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["apellido"].Value.ToString();
                string email = filaSeleccionada.Cells["email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["telefono"].Value.ToString();
                string direccion = filaSeleccionada.Cells["direccion"].Value.ToString();                

                EditClientsView editClients = new EditClientsView(nombre, apellido, email, telefono, direccion);
                editClients.Show();
                //this.Close();
                //MessageBox.Show($"Se seleccionó la fila:\nNombre: {nombre}\nCódigo de Producto: {codigoProducto}\nPrecio: {precio}");
            }
        }
    }
}
