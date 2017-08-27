using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Client
    {
        //private ObjectId id;
        private String email;
        private String password;
        private String name;
        private String birthday;

        public Client()
        {
            this.email = "email";
            this.name = "name";
            this.Password = "password";
            this.birthday = "birthday";
        }//constructor default

        public Client(String email, String password,String name, String birthday)
        {
            this.email = email;
            this.name = name;
            this.birthday = birthday;
            this.password = password;

        }//Constructor

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

        public String Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public String Birthday
        {
            get
            {
                return this.birthday;
            }

            set
            {
                this.birthday = value;
            }
        }

        public String Password
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
    }//end class
}//end namespace
