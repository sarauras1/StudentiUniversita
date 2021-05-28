using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPStudenti
{
    class Gestione
    {


        public static List<Studente> registrazioni = new List<Studente>()
        {
            
        };
        public static List<Studente> studenti = new List<Studente>()
        {
          new Studente(){Nome="Sara", Cognome="Uras", AnnoNascita=1987, Password="1234", UserName="SaraU"}
        };
        public static Studente IsAutenticato(string user, string password)
        {
            foreach (var item in studenti)
            {
                if (item.UserName == user && item.Password == password)
                {
                    item.StampaStudente();
                    return item;
                }
            }
            return null;
        }

    }
}
