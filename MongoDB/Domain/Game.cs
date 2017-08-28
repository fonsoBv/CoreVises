using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        public class Game
        {
            private ObjectId id;
            private int idGame;
            private string name;
            private int type;
            private int consol;
            private float price;


            public Game()
            {
                this.IdGame = 0;
                this.name = "name";
                this.type = 0;
                this.consol = 0;
                this.price = 0;
            }//constructor default

            public Game(int idGame,string name, int type, int consol,float price)
            {
                this.name = name;
                this.type = type;
                this.consol = consol;
                this.price = price;
            }//constrctor
            public ObjectId Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public int Type
            {
                get
                {
                    return type;
                }

                set
                {
                    type = value;
                }
            }

            public int Consol
            {
                get
                {
                    return consol;
                }

                set
                {
                    consol = value;
                }
            }//end class

    public float Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public ObjectId Id1
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public int IdGame
    {
        get
        {
            return idGame;
        }

        set
        {
            idGame = value;
        }
    }
}//end namespacea
   