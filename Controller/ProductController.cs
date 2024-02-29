using ABMdotNet.Model;
using ABMdotNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Controller
{
    public class ProductController
    {
        ProductRepository Repository = new ProductRepository();
        public List<Product> getProducts()
        {                        
            List<Product> Products = Repository.getProducts();
            return Products;
        }
        public Boolean insertProduct(Product product)
        {            
            return Repository.insertProduct(product);
        }
        public Boolean updateProduct(Product product)
        {
            List<Product> Products = Repository.getProducts();
            Product ProductEdit = new Product();
            for (int i = 0; i < Products.Count; i++)
            {
                if(product.CodigoProducto == Products[i].CodigoProducto)
                {
                    ProductEdit = Products[i];
                }
            }
            if(ProductEdit == null)
            {
                return false;
            } else
            {                
                return Repository.editProduct(ProductEdit);
            }
        }
    }
}
