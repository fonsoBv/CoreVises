using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Purchase
    {
        private ObjectId idPurchase;
        private int codProduct;
        private string email;
        private int quantity;
        private double price;
        private DateTime datePurchase;


        public Purchase()
        {
            this.codProduct = 0;
            this.email = "email@user.com";
            this.quantity = 0;
            this.price = 0;
            this.datePurchase = DateTime.Today;

        }
        public Purchase(int codProduct, string email, int quantity, double price, DateTime datePurchase)
        {
            this.codProduct = codProduct;
            this.email = email;
            this.quantity = quantity;
            this.price = price;
            this.datePurchase = datePurchase;
        }

        public int CodProduct
        {
            get
            {
                return codProduct;
            }

            set
            {
                codProduct = value;
            }
        }

        public string Email
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

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Price
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

        public DateTime DatePurchase
        {
            get
            {
                return datePurchase;
            }

            set
            {
                datePurchase = value;
            }
        }

        public String toString
        {
            get
            {
                return "Purchase " + this.IdPurchase + " Cod= " + this.codProduct + " email= " +
                    this.email + " Quantity= " + this.quantity + " Price= $" + this.price;
            }
        }

        public ObjectId IdPurchase
        {
            get
            {
                return idPurchase;
            }

            set
            {
                idPurchase = value;
            }
        }
    }
}
