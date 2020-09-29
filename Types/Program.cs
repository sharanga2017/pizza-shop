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
            Console.WriteLine("Bienvenus Pizza Shop !!");
            Dao.AfficherVetrine();
            Dao.Login();
            Console.ReadKey();
        }
    }

    



    class Users
    {
        public List<User> Clients { get; set; } = new List<User>();


    }






    

    class Commande
    {
        public List<Pizza> listeDePizza { get; set; }

        public User Client { get; set; }


    }


}



