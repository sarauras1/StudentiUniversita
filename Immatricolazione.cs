using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPStudenti
{
    public class Immatricolazione
    {
        public int Matricola { get; }
        public string DataInizio { get; set; }
        public static int imm = 100;
        public CorsoLaurea CorsoLaurea { get; set; } = new CorsoLaurea();
        public string FuoriCorso { get; set; }

        public int Cfui { get; set; }


        public Immatricolazione(string datainizio, string corsolaurea, string fuoricorso, int cfua)
        {

            DataInizio = datainizio;
            CorsoLaurea = new CorsoLaurea();
            FuoriCorso = fuoricorso;
            Cfui = cfua;
            Matricola = imm++;
        }
        public Immatricolazione()
        {


        }
        public void StampaImmatricolazione()
        {
            Console.WriteLine($"DataInizio: {DataInizio} CorsoLaurea: {CorsoLaurea} Sei Fuori Corso?: {FuoriCorso} Numero Matricola: {Matricola}");
        }
    }

}
