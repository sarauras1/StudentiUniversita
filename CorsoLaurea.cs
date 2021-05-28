using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPStudenti
{
    public class CorsoLaurea
    {
        public Corsi Corsi { get; set; } = new Corsi();
        public int AnnoCorso { get; set; }
        public int Cfu { get; set; }
        public string Corso { get; set; }
        public CorsoLaurea(int annocorso, int cfu, string corso)
        {
          AnnoCorso = annocorso;
          Cfu = cfu;
          Corsi = new Corsi();
            Corso = Corso;

        }
        public CorsoLaurea()
        {

        }
    }

}
