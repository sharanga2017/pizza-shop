using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Dao.ChargerUsers();
            Dao.ChargerPizzas();
            Console.WriteLine("Bienvenus Pizza Shop !!!");
            Dao.AfficherVetrine();
            Dao.Login();
            Console.ReadKey();
        }
    }

    public class User
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }



    class Users
    {
        public List<User> Clients { get; set; } = new List<User>();


    }






    public class Pizza
    {
        public string Name { get; set; }

        public float Prix { get; set; }

        public Pizza()
        {

        }
    }


    class Commande
    {
        public List<Pizza> listeDePizza { get; set; }

        public User Client { get; set; }


    }


}



