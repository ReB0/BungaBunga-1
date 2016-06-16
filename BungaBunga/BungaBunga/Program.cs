﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungaBunga
{
    class Program : Iestrometti, Ibungabunga, Iintroduci
    {
        private List<Politico> ListaPolitici = new List<Politico>();
        private List<Escort> ListaEscort = new List<Escort>();

        static void Main(string[] args)
        {
            Console.ReadKey();

           /*estrai una riga da file
            * if(prima_parola_da_file==in) {
            * Politico P = new Politico;
            * introduci_politico(specifiche_da_file);
            * ListaPolitici.Add(P)
            * }
            * 
            * if(prima_parola_da_file==out){
            * estrometti(seconda_parola_in_file)
            * }
            * 
            * 
            * 
            */

        }
        

        public void introduci_politico(string nome,char sesso,int denaro,int età,int altezza,int peso,float colorecapelli,float costituzione,string presenze, Politico P)
        {
            P.Nome = nome;
            P.Sesso = sesso;
            P.Denaro = denaro;
            P.Età = età;
            P.Altezza = altezza;
            P.Peso = peso;
            P.Colorecapelli = colorecapelli;
            P.Costituzione = costituzione;
            P.Presenze = presenze;


        }

        public void introduci_escort(string nome, char sesso, int denaro, int età, int altezza, int peso, float colorecapelli, float costituzione, string presenze, Escort E)
        {
            E.Nome = nome;
            E.Sesso = sesso;
            E.Denaro = denaro;
            E.Età = età;
            E.Altezza = altezza;
            E.Peso = peso;
            E.Colorecapelli = colorecapelli;
            E.Costituzione = costituzione;
            E.Presenze = presenze;


        }



        public void estrometti(string nome)
        {

            var politico_estromesso = ListaPolitici.SingleOrDefault(x => x.Nome == nome); // controlla se il soggetto è già presente nella lista
            if (politico_estromesso != null) ListaPolitici.Remove(politico_estromesso);  // elimina il soggetto dalla lista

            var escort_estromessa = ListaEscort.SingleOrDefault(x => x.Nome == nome);
            if (escort_estromessa != null) ListaEscort.Remove(escort_estromessa);
            
        }



        public void bungabunga(char giorno, int Naccoppiamenti)
        {
            List<Tuple<Politico, Escort, float>> ListaDiAffinità = new List<Tuple<Politico, Escort, float>>();
            //per ogni possibile coppia Politico-Escort calcoliamo la discrepanza secondo le indicazioni del testo, e generiamo una Tupla <Politico, Escort, float> da inserire nella lista

            //ultimata la generazione della lista, la riordiniamo per discrepanza
            //consideriamo solo gli Naccoppiamenti migliori della lista
            //chiamiamo la funzione "GeneraOrgie" per calcolare il numero di gruppetti che si vengono a formare
            //chiamiamo la funzione "TrovaOrgione" per identificare la stanza con più elementi -> ci restituisce una lista/array di 3 interi che rappresentano l'output richiesto






        }



        private double CalcolaAffinità(Politico P, Escort E)  //restituisce il valore di discrepanza tra le preferenze del politico e le caratteristiche della Escort
        {
            double Affinità = 0;
            double[] importanza = {0.00009, 1.0, 0.1, 0.15, 0.5, 2.0};
            Affinità = Math.Abs(P.Denaro - E.Denaro) * importanza[1] + Math.Abs(P.Età - E.Età) * importanza[2] + Math.Abs(P.Altezza - E.Altezza) * importanza[3] + Math.Abs(P.Peso - E.Peso) * importanza[4] + Math.Abs(P.Colorecapelli - E.Colorecapelli) * importanza[5] + Math.Abs(P.Costituzione - E.Costituzione) * importanza[6];
            return Affinità;
        }



        private Tuple<string,string> LeggiIstruzione(int n)  //legge l'istruzione alla riga n-esima nel file di input e la restituisce interpretata nella forma di Tupla <(IDevento), (parametri)>
        {
            string istruzione=null;
            string parametri = null;
            //gestione lettura da file

            //interpretazione della riga letta (istruzione=.... ; parametri = ..... ; NB: i parametri saranno nello stesso ordine del testo, e separati da " ")

            Tuple<string, string> tupla = new Tuple<string, string>(istruzione, parametri);
            return tupla;
        }


    }
}
