using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB
{
    public partial class Ventana : Form
    {
        private ObjectId id;
        public Ventana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("store_games");
                ms.Connect(); // creo q este no hace falta ahorita veo

                var persona = new Persona (){ Cedula = textBox1.Text, Name = textBox2.Text };
                this.id = persona.Id;
                MongoCollection colleccion = db.GetCollection<Persona>("persona");
                colleccion.Insert(persona);
                MessageBox.Show("Persona guardada");
            }catch(Exception error) {
                MessageBox.Show("ERROR "+ error);
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect(); // creo q este no hace falta ahorita veo

            var collection = db.GetCollection<Persona>("persona");
            var query = Query<Persona>.EQ(p => p.Cedula,textBox1.Text);
            var update = Update<Persona>.Set(p => p.Name, textBox2.Text); // update modifiers
            collection.Update(query, update);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            MongoClient mc = new MongoClient("mongodb://store_products:1234@ds153123.mlab.com:53123/store_games");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("store_games");
            ms.Connect(); // creo q este no hace falta ahorita veo

            MongoCollection collection = db.GetCollection<Persona>("persona");
                var query = Query<Persona>.EQ(p => p.Cedula, textBox1.Text);
                var persona = collection.FindAs<Persona>(query);
                foreach (Persona item in persona) {
                    if (item.Cedula=="12") {
                        textBox1.Text = item.Cedula;
                        textBox2.Text = item.Name;
                    }
                    }
        }catch(Exception error) {
                MessageBox.Show("ERROR "+ error);
            }

}
    }
}
