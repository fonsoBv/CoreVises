using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GameBussines
    {
        private GameData gameData;

        public GameBussines()
        {
            this.gameData = new GameData();
        }//constructor

        public void insertGame(Game game)
        {
            this.gameData.insertGame(game);
        }//insertGame

        public void updateGame(Game game)
        {
            this.gameData.updateGame(game);
        }//updateGame

        public void deleteGame(String id)
        {
            this.gameData.delete(id);
        }
    }
}
