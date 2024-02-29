using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoPagar { get; set; }
        public string Nombre_Producto {  get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Email_Cliente { get; set; }
        public string Codigo_Producto { get; set; }
    }
}
