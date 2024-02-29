using ABMdotNet.Model;
using ABMdotNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Controller
{
    public class ClientController
    {
        ClientRepository Repository = new ClientRepository();
        public List<Client> getClients()
        {
            List<Client> Clients = Repository.getClients();
            return Clients;
        }
        public Boolean insertClient(Client client)
        {
            return Repository.insertClient(client);
        }
        public Boolean updateClient(Client client)
        {
            List<Client> Clients = Repository.getClients();
            Client ClientEdit = new Client();
            for (int i = 0; i < Clients.Count; i++)
            {
                if (client.Email == Clients[i].Email)
                {
                    ClientEdit = Clients[i];
                }
            }
            if (ClientEdit == null)
            {
                return false;
            }
            else
            {
                return Repository.editClient(ClientEdit);
            }
        }
    }
}
