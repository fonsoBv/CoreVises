using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class Administrator
    {
       // private ObjectId id;
        private String user;
        private String password;

        public Administrator()
        {
            this.user = "user";
            this.password = "pass";
        }
        public Administrator(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        //public ObjectId Id
        //{
        //    get
        //    {
        //        return id;
        //    }

        //    set
        //    {
        //        id = value;
        //    }
        //}

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
