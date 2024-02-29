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
    public partial class AddProductsView : Form
    {
        public AddProductsView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = textBoxNombre.Text;
            string Codigo = textBoxCodigo.Text;
            string PrecioString = textBoxPrecio.Text;            
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Codigo) || string.IsNullOrEmpty(PrecioString))
            {
                clearAndShowMessage("Todos los campos deben estar cargados");
            }
            try
            {
                int Precio = int.Parse(PrecioString);
                Product product = new Product();
                product.Nombre = Nombre;
                product.CodigoProducto = Codigo;
                product.Precio = Precio;
                ProductController Controller = new ProductController();
                if (Controller.insertProduct(product))
                {
                    MessageBox.Show("Producto insertado correctamente");
                    this.Close();
                } else
                {
                    clearAndShowMessage("El producto no fue ingresado");
                }
            }
            catch (FormatException)
            {
                clearAndShowMessage("El precio ingresado no es válido");
            }           
        }

        private void clearAndShowMessage(string message)
        {
            MessageBox.Show(message);
            textBoxNombre.Text = "";
            textBoxCodigo.Text = "";
            textBoxPrecio.Text = "";
        }
    }
}
