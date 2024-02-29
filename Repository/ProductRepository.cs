using ABMdotNet.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Repository
{
    public class ProductRepository
    {
        public List<Product> getProducts()
        {            
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                List<Product> Products = new List<Product>();
                SqlCon = Connection.getInstance().CreateConnection();
                OracleCommand Command = new OracleCommand("select * from productos", SqlCon);
                Command.CommandType = CommandType.Text;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                while(Result.Read())
                {
                    Product product = new Product();
                    product.Nombre = Convert.ToString(Result["nombre"]);
                    product.CodigoProducto = Convert.ToString(Result["codigo_producto"]);
                    product.Precio = Convert.ToInt32(Result["precio"]);
                    Products.Add(product);
                }
                
                return Products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Boolean insertProduct(Product product)
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {                
                SqlCon = Connection.getInstance().CreateConnection();
                string sqlString = "INSERT INTO Productos (nombre, codigo_producto, precio) " +
                                    "VALUES ('" + product.Nombre +
                                    "', '" + product.CodigoProducto + "" +
                                    "', "+ product.Precio.ToString() + ")";
                OracleCommand Command = new OracleCommand(sqlString, SqlCon);
                Command.CommandType = CommandType.Text;                
                SqlCon.Open();
                Result = Command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Boolean editProduct(Product product)
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConnection();
                string sqlString = "UPDATE Productos" +
                                    " SET nombre ='" + product.Nombre +
                                    "', precio=" + product.Precio.ToString() +
                                    " WHERE codigo_producto= '" + product.CodigoProducto + "'";
                OracleCommand Command = new OracleCommand(sqlString, SqlCon);
                Command.CommandType = CommandType.Text;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
