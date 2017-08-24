using Domain;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClientData
    {
        public ClientData()
        { }//constructor vacio

        public void insertClient(Client client)
        {

            try
            {

                //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
                MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("store_games");
                ms.Connect();
                MongoCollection colleccion = db.GetCollection<Game>("client");
                colleccion.Insert(client);

            }
            catch (Exception error) { };

        }//insertCLient

        public int initSesssion(Client client)
        {
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Client>("client");
            //var query = Query<Administrator>.EQ(a => a.User, admi.User);
            MongoCollection<Client> clients = db.GetCollection<Client>("client");
            var clientes = clients.FindAll();
            foreach (var item in clientes)
            {
                if (item.Email == client.Email && item.Password == client.Password)
                {
                    return 1;
                }

            }//foreach
            return 0;
        }//initSession

        public MongoCollection<Game> clients()
        {
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Game>("client");
            MongoCollection<Game> clients = db.GetCollection<Game>("client");

            return clients;

        }//CLients

        public void updateClient(Client client)
        {

            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();
            var query = Query<Client>.EQ(c => c.Email, client.Email);
            var user = Update<Client>.Set(c => c.Email, client.Email);
            var password = Update<Client>.Set(c => c.Password, client.Password);
            MongoCollection colleccion = db.GetCollection<Client>("client");
            colleccion.Update(query, user);
            colleccion.Update(query, password);

        }//updateCLient

        public void deleteClient(String email)
        {
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Client>("client");
            MongoCollection<Client> clients = db.GetCollection<Client>("client");
            var query = Query<Client>.EQ(c => c.Email, email);
            clients.Remove(query);
        }//deleteClient
    }//end class
}//end namespace
