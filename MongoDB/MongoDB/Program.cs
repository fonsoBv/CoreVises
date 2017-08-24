using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {

            Ventana ventana = new Ventana();
            ventana.ShowDialog(); 
        }
    }
}
