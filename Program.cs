using System;

namespace APPStudenti
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto all universita Bocconi");
            Console.WriteLine("Inserisci Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Inserisci Password:");
            string password = Console.ReadLine();

            //login studente
            Studente u = new Studente();
            u = Gestione.IsAutenticato(username, password);
            if (u == null)
            {
                Console.WriteLine("\n Non sei registrato. Vuoi registrarti? SI/NO");
                string risposta = Console.ReadLine();
                if (risposta.ToUpper() == "SI")
                {
                    Registrazione();


                }
                else
                {
                    Console.WriteLine("Bye Bye");
                }
            }

        }

            private static void Registrazione()//registrazione studente nuovo
            {
               
                Studente u = new Studente();
                Console.Write("\n completa la registrazione. \n Inserisci Nome:");
                u.Nome = Console.ReadLine();
                Console.Write(" \n Inserisci Cognome:");
                u.Cognome = Console.ReadLine();
                Console.Write(" \n Inserisci UserName:");
                u.UserName = Console.ReadLine();
                Console.Write(" \n Inserisci Password:");
                u.Password = Console.ReadLine();
                Console.Write(" \n inserisci anno di nascita:");
                u.AnnoNascita = int.Parse(Console.ReadLine());                      
                Console.WriteLine(" \n scegli corso:");
                Console.WriteLine(" \n Fisica");
                Console.WriteLine(" \n Matematica");               
                Console.WriteLine(" \n  Ingenieria");              
               Console.WriteLine(" \n Lettere");
               Console.WriteLine(" \n  Informatica");
               u.CorsoLaurea.Corso = Console.ReadLine();
                Gestione.registrazioni.Add(u);
           
           if(u.Nome != null || u.Cognome != null || u.UserName != null || u.Password != null || u.CorsoLaurea.Corso != null)
            {
                Console.Write("Complimenti ti sei inscritto");
            }
             
            }






      
            }
        }
  

