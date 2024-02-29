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
    public class SaleRepository
    {
        public List<Sale> getSales()
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                List<Sale> Sales = new List<Sale>();
                SqlCon = Connection.getInstance().CreateConnection();
                OracleCommand Command = new OracleCommand("SELECT p.nombre AS nombre_producto,"+
                    " p.precio AS precio_producto, p.codigo_producto AS codigo_producto, v.monto_pagar AS monto_pagar, "+
                    "c.nombre AS nombre_cliente,"+
                    " c.apellido AS apellido_cliente, c.email AS email_cliente "+
                    "FROM Ventas v JOIN Productos p ON v.id_producto = p.id "+
                    "JOIN Clientes c ON v.id_cliente = c.id", SqlCon);
                Command.CommandType = CommandType.Text;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                while (Result.Read())
                {
                    Sale sale = new Sale();
                    sale.Nombre_Producto = Convert.ToString(Result["nombre_producto"]);                    
                    sale.MontoPagar = Convert.ToDecimal(Result["monto_pagar"]);
                    sale.Codigo_Producto = Convert.ToString(Result["codigo_producto"]);
                    sale.Nombre_Cliente = Convert.ToString(Result["nombre_cliente"]);
                    sale.Apellido_Cliente = Convert.ToString(Result["apellido_cliente"]);
                    sale.Email_Cliente = Convert.ToString(Result["email_cliente"]);                  
                    Sales.Add(sale);
                }

                return Sales;
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
                                    "', " + product.Precio.ToString() + ")";
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
