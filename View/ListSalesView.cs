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
    public partial class ListSalesView : Form
    {
        public ListSalesView()
        {
            InitializeComponent();
            SaleController Controller = new SaleController();
            List<Sale> Sales = Controller.getSales();
            if (Sales.Count == 0)
            {
                MessageBox.Show("No se encuentran ventas para mostrar");
            }
            else
            {
                dataGridViewSales.Rows.Clear();
                for (int i = 0; i < Sales.Count; i++)
                {
                    dataGridViewSales.Rows.Add(Sales[i].Nombre_Producto, Sales[i].Codigo_Producto, Sales[i].MontoPagar, Sales[i].Nombre_Cliente, Sales[i].Apellido_Cliente, Sales[i].Email_Cliente);
                }
            }
        }

        private void ListSalesView_Load(object sender, EventArgs e)
        {

        }
    }
}
