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
    public partial class ListProductsView : Form
    {
        public ListProductsView()
        {            
            InitializeComponent();
            ProductController Controller = new ProductController();
            List<Product> Products = Controller.getProducts();
            if (Products.Count == 0)
            {
                MessageBox.Show("No se encuentran productos disponibles para mostrar");
            }
            else
            {
                dataGridViewProducts.Rows.Clear();
                for (int i = 0; i < Products.Count; i++)
                {
                    dataGridViewProducts.Rows.Add(Products[i].Nombre, Products[i].CodigoProducto, Products[i].Precio);
                }
            }
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {            
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en el encabezado de la columna)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewProducts.Rows[e.RowIndex];

                // Acceder a los valores de las celdas en la fila seleccionada
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                string codigoProducto = filaSeleccionada.Cells["codigo_producto"].Value.ToString();
                int precio = Convert.ToInt32(filaSeleccionada.Cells["precio"].Value.ToString());

                EditProductsView editProducts = new EditProductsView(nombre, codigoProducto, precio.ToString());
                editProducts.Show();
                //this.Close();
                //MessageBox.Show($"Se seleccionó la fila:\nNombre: {nombre}\nCódigo de Producto: {codigoProducto}\nPrecio: {precio}");
            }
        }
    }
}
