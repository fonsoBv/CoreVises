using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AdministratorData {

        public AdministratorData()
        {}//constructor vacio

        public void insertAdmi(Administrator admi){

            try {

                    MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
                //MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("store_games");
                ms.Connect();
                MongoCollection colleccion = db.GetCollection<Administrator>("administrator");
                colleccion.Insert(admi);

            }catch(Exception error) {};

        }//insertAdmi

        public int initSesssion(Administrator admi){
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Administrator>("administrator");
            //var query = Query<Administrator>.EQ(a => a.User, admi.User);
            MongoCollection<Administrator> admis =  db.GetCollection<Administrator>("administrator");
            var administrator = admis.FindAll();
            foreach (var item in administrator)
            {
                if (item.Password == admi.Password && item.User == admi.User) { 
                    return 1;
                }

            }//foreach
            return 0;
        }//initSession

        public MongoCollection<Administrator> administrators()
        {
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = db.GetCollection<Administrator>("administrator");

            return admis;

        }//adminisitradores

        public void updateAdmi(Administrator admi)
        {

            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();
            var query = Query<Administrator>.EQ(a => a.User, admi.User);
            var user = Update<Administrator>.Set(a => a.User, admi.User);
            var password = Update<Administrator>.Set(a => a.Password, admi.Password);
            MongoCollection colleccion = db.GetCollection<Administrator>("administrator");
            colleccion.Update(query, user);
            colleccion.Update(query, password);

        }//updateAdmi

        public void deleteAdmi(String user)
        {
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = db.GetCollection<Administrator>("administrator");
            var query = Query<Administrator>.EQ(a => a.User, user);
            admis.Remove(query);
        }

    }//end class

   

}//namespace
