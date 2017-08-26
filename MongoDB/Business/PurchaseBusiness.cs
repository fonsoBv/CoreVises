using System;
using Data;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PurchaseBusiness
    {
        private PurchaseData purchaseD;
        public PurchaseBusiness()
        {
            purchaseD = new PurchaseData();
        }

        public void createPurchase(Purchase purchase)
        {
            this.purchaseD.createPurchase(purchase);
        }

        public void retrivePurchase()
        {
            this.purchaseD.retrivePurchase();
        }

    }
}
