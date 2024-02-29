using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
        public decimal Precio { get; set; }
    }
}
