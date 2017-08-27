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
            private String name;
            private String type;
            private String consol;
            private float price;


            public Game()
            {
                this.name = "name";
                this.type = "type";
                this.consol = "consol";
                this.price = 0;
            }//constructor default

            public Game(string name, string type, string consol,float price)
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

            public string Type
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

            public string Consol
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
}//end namespacea
   