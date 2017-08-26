using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace Library
{
    
    public class MongoConnection
    {
        private MongoClient mongoClient;
        private MongoServer mongoServer;
        private MongoDatabase mongoDBase;
        private MongoCollection colleccion;

        public MongoDatabase MongoDBase
        {
            get
            {
                return mongoDBase;
            }

            set
            {
                mongoDBase = value;
            }
        }

        public MongoConnection()
        {
            try
            {
                mongoClient = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
                //mongoClient = new MongoClient("mongodb://localhost:27017/store_games");
                mongoServer = mongoClient.GetServer();
                MongoDBase = mongoServer.GetDatabase("store_games");
                mongoServer.Connect();
                //colleccion = db.GetCollection<Game>("client");
                //colleccion.Insert(client);
            }
            catch (Exception error) {
                Console.WriteLine(error);
            };
        }

        

    }
}
