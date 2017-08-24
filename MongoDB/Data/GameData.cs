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
   public class GameData
    {
        public GameData()
        {}//constructor

        public void insertGame(Game game)
        {

            try
            {

                //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
                MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("store_games");
                ms.Connect();
                MongoCollection colleccion = db.GetCollection<Game>("game");
                colleccion.Insert(game);

            }
            catch (Exception error) { };
        }//insertGame

        public void updateGame(Game game)
        {
             //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();
            var query = Query<Game>.EQ(g => g.Id, game.Id);
            var name = Update<Game>.Set(g=> g.Name, game.Name);
            var tipo = Update<Game>.Set(g => g.Type, game.Type);
            MongoCollection colleccion = db.GetCollection<Game>("client");
            colleccion.Update(query, name);
            colleccion.Update(query, tipo);
        }//updateGame

        public void delete(String id)
        {
            ObjectId idN = new ObjectId(id);
            //MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoClient mc = new MongoClient("mongodb://localhost:27017/store_games");

            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect();

            var collection = db.GetCollection<Game>("game");
            MongoCollection<Game> games = db.GetCollection<Game>("game");
            var query = Query<Game>.EQ(g => g.Id, idN);
            games.Remove(query);
        }

    }//end class
}//end namespace
