using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Types
{
    class Dao
    {

        public static List<Pizza> ListeDePizzas { get; set; } = new List<Pizza>();
        public static List<User> Clients { get; set; } = new List<User>();



        public static List<Pizza> GetPizzas()
        {

            return ListeDePizzas;

        }

        internal static void AfficherVetrine()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Aujoudhui vous pouvez commander les pizzas : ");
            Console.WriteLine("***********************************");
            Console.WriteLine();
            Console.WriteLine();

            List<Pizza> pizzas = Dao.ListeDePizzas;
            int i = 1;
            foreach (var item in pizzas)
            {
                Console.WriteLine("{0} {1} prix : {2}", i++, item.Name, item.Prix);
                Console.WriteLine("***********************************");


            }
        }



        public static void Login()
        {
            Console.WriteLine("Veillez saisir votre login : ");
            string entree = Console.ReadLine();
            if (Dao.LoginExiste(entree))
            {
            
                if(!Continuer())
                {
                    Console.WriteLine("Bye bye !!!");
                    Console.WriteLine("Exite");

                }
            ReStart:
                Console.WriteLine("Saisi la pwd !! svp ");
                string pwd = Console.ReadLine();
                if (!Dao.isClientAuth(entree, pwd))
                {
                    goto ReStart;
                }

            }
        }


        public static bool Continuer()
        {

            Restart:
            Console.WriteLine("Cotinuer tapez (1) ou Tapez l'autre pour exite : ");
            string saisi = Console.ReadLine();

            int number;

            bool success = int.TryParse(saisi, out number);

            if (success)
            {
                if (number == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }               

            }
            else
            {
                goto Restart;
            }

        }

        public static bool LoginExiste(string entree)
        {
            List<User> users = Dao.Clients;

            foreach (var item in users)
            {
                if (item.Login == entree)
                {
                    return true;
                }
            }

            return false;

        }

        internal static bool isClientAuth(string entree, string pwd)
        {
            foreach (var item in Clients)
            {
                if(entree == item.Login)
                {
                    if( item.Password == pwd)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        

        public static void ChargerPizzas()
        {
            Pizza pizza1 = new Pizza();
            pizza1.Name = "Pizza vegeterien";
            pizza1.Prix = 10.0f;
            Pizza pizza2 = new Pizza();
            pizza2.Name = "Pizza Soumon";
            pizza2.Prix = 13.0f;
            ListeDePizzas.Add(pizza1);
            ListeDePizzas.Add(pizza2);
        }


        public static void ChargerUsers()
        {
            User client1 = new User();
            client1.Nom = "Khan";
            client1.Prenom = "Serguei";
            client1.Login = "serguei.khan@gmail.com";
            client1.Password = "password123";


            User client2 = new User();
            client2.Nom = "Ivanov";
            client2.Prenom = "Igor";
            client2.Login = "igor_bogrov.khan@gmail.com";
            client2.Password = "pwd123";


            Clients.Add(client1);
            Clients.Add(client2);



        }
    }
}
