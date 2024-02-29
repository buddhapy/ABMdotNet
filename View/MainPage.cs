using ABMdotNet.Repository;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            //ProductRepository Pr = new ProductRepository();
            //DataTable Dt = new DataTable();
            //Dt = Pr.getProducts();
            //Console.WriteLine(Dt.Rows.Count);
            InitializeComponent();
        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListProductsView listProducts = new ListProductsView();
            listProducts.Show();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void agregarProducotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductsView addProducts = new AddProductsView();
            addProducts.Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClientsView listClientsView = new ListClientsView();
            listClientsView.Show();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientsView addClientsView = new AddClientsView();
            addClientsView.Show();
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSalesView listSales = new ListSalesView();
            listSales.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
