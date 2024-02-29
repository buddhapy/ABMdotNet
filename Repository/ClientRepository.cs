using ABMdotNet.Model;
using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Repository
{
    public class ClientRepository
    {
        public List<Client> getClients()
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                List<Client> Clients = new List<Client>();
                SqlCon = Connection.getInstance().CreateConnection();
                OracleCommand Command = new OracleCommand("select * from clientes", SqlCon);
                Command.CommandType = CommandType.Text;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                while (Result.Read())
                {
                    Client client = new Client();
                    client.Nombre = Convert.ToString(Result["nombre"]);
                    client.Apellido = Convert.ToString(Result["apellido"]);
                    client.Email = Convert.ToString(Result["email"]);
                    client.Telefono = Convert.ToString(Result["telefono"]);
                    client.Direccion = Convert.ToString(Result["direccion"]);
                    Clients.Add(client);
                }

                return Clients;
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

        public Boolean insertClient(Client client)
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConnection();
                string sqlString = "INSERT INTO Clientes (nombre, apellido, email, telefono, direccion) " +
                                    "VALUES ('" + client.Nombre +
                                    "', '" + client.Apellido + "" +
                                    "', '" + client.Email + "" +
                                    "', '" + client.Telefono + "" +                                    
                                    "', " + client.Direccion + ")";
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

        public Boolean editClient(Client client)
        {
            OracleDataReader Result;
            DataTable Table = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConnection();
                string sqlString = "UPDATE Clientes" +
                                    " SET nombre ='" + client.Nombre +
                                    "', apellido='" + client.Apellido +
                                    "', telefono='" + client.Email +
                                    "', direccion='" + client.Direccion +                                    
                                    "' WHERE email= '" + client.Email + "'";
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
