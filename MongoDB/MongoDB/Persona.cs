using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class Persona
    {
        private ObjectId id;
        private String name;
        private String cedula;

        public Persona()
        {
            this.name = "nombre";
            this.cedula = "cedula";
        }

        public Persona(string name, string cedula)
        {
            this.name = name;
            this.cedula = cedula;
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

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

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
    }
}
