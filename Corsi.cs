using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPStudenti
{
   public class Corsi
    {

        public string Matematica { get; set; }
        public string Fisica { get; set; }
        public string Informatica { get; set; }
        public string Ingenieria { get; set; }
        public string Lettere { get; set; }


        public Corsi(string matematica, string fisica, string lettere, string ingenieria, string informatica)
        {
            Matematica = matematica;
            Fisica = fisica;
            Informatica = informatica;
            Ingenieria = ingenieria;
            Lettere = lettere;
        }
       
      public Corsi()
        {

        }

    }
}
        