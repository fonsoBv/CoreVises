using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            init();
        }

       public void init()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var admi = new Administrator() { User = textBox1.Text, Password=textBox2.Text };
            AdministratorBussines admiBusi = new AdministratorBussines();
            admiBusi.insertAdmi(admi);
            MessageBox.Show("Guardado");
        }


        private void initSession(object sender, EventArgs e)
        {
            var admi = new Administrator() { User = textBox1.Text, Password = textBox2.Text };
            AdministratorBussines admiBusi = new AdministratorBussines();
            if (admiBusi.initSession(admi) == 1)
            {
                MessageBox.Show("Sesion Exitosa");
            }
            else
            {
                MessageBox.Show("ERRor de confirmacion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var admi = new Administrator() { User = textBox1.Text, Password = textBox2.Text };
            AdministratorBussines admiBusi = new AdministratorBussines();
            admiBusi.updateAdmi(admi);
            MessageBox.Show("Usuario: "+ admi.User +" actualizado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdministratorBussines admiBusi = new AdministratorBussines();
            admiBusi.deleteAdmi(textBox1.Text);
            MessageBox.Show("Usuario: " + textBox1.Text + " eliminado");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(1, "user@user.com", 2, 200, DateTime.Today);
            PurchaseBusiness PurchaseB = new PurchaseBusiness();
            PurchaseB.createPurchase(purchase);
            
        }
    }
}
