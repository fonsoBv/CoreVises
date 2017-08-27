using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class ClientBussines
    {
        private ClientData clienData;
        public ClientBussines()
        {
            this.clienData = new ClientData();
        }//constructor

        public void insertClient(Client client)
        {
            this.clienData.insertClient(client);
        }//insertClient

        public void updateClient(Client client)
        {
            this.clienData.updateClient(client);
        }//updateClient

        public void deletClient(Client client)
        {
            this.deletClient(client);
        }//deleClient

        public int initSession(Client client)
        {
            return this.clienData.initSesssion(client);
        }//initSession
    }//end class
}//end namespace
