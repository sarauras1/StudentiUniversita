using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPStudenti
{
    public class Studente
    {


        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Corsi Corsi { get; set; } = new Corsi();
        public CorsoLaurea CorsoLaurea { get; set; } = new CorsoLaurea();
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public string Esami { get; set; }
     
        public string Password { get; set; }
        public string UserName { get; set; }

        public int AnnoNascita { get; set; }

        public string Datainizio { get; }

        public Studente(string username, string nome, string cognome, int annonascita, string password)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annonascita;          
            Password = password;
            UserName = username;
            Immatricolazione = new Immatricolazione();
            CorsoLaurea = new CorsoLaurea();
            Corsi = new Corsi();
        }
        public Studente()
        {

        }



        public void StampaStudente()
        {
            Console.WriteLine($"Nome: {Nome} Cognome: {Cognome} UserName: {UserName} AnnoDiNascita: {AnnoNascita}" );
        }
    }
}
