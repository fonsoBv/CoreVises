using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AdministratorBussines
    {

        private AdministratorData administradorData;
        public AdministratorBussines()
        {
            this.administradorData = new AdministratorData();
        }//constructor

        public void insertAdmi(Administrator admi)
        {
            this.administradorData.insertAdmi(admi);
        }//insertAdmi

        public int initSession(Administrator admi)
        {
            return this.administradorData.initSesssion(admi);
        }//initSession

        public void updateAdmi(Administrator admi)
        {
            this.administradorData.updateAdmi(admi);
        }//updateAdmi

        public void deleteAdmi(String user)
        {
            this.administradorData.deleteAdmi(user);
        }//updateAdmi

      
    }//end class
}
