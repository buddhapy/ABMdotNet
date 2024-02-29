using ABMdotNet.Model;
using ABMdotNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Controller
{
    public class SaleController
    {
        SaleRepository Repository = new SaleRepository();
        public List<Sale> getSales()
        {
            List<Sale> Sales = Repository.getSales();
            return Sales;
        }
    }
}
