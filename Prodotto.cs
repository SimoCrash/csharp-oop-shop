﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        public int codice;
        public string nome;
        public string nomeCompleto;
        public string descrizione;
        public double prezzo;
        public int iva;
        public double prezzoTotale;

        public Prodotto(string Name, string Description, double Price, int Iva)
        {
            codice = GeneratedCode();
            nome = Name;
            nomeCompleto = FullName(Convert.ToString(this.codice), Name); //come si fa per stampare il nome completo con il nome inserito in setName()?
            descrizione = Description;
            prezzo = Price;
            iva = Iva;
            prezzoTotale = GeneratedPrice(Price, Iva); //come si fa per stampare il prezzo totale con l'aliquota inserita in setIva()?
        }
        public int getCode()
        {
            return this.codice;
        }

        public string getName() 
        { 
            return this.nome;
        }

        public string setName(string Value)
        {
            return this.nome = Value;
        }

        public string getDescription()
        {
            return this.descrizione;
        }

        public string setDescription(string Value)
        {
            return this.descrizione = Value;
        }

        public double getPrice()
        {
            return this.prezzo;
        }

        public double setPrice(double Value)
        {
            return this.prezzo = Value;
        }

        public int getIva()
        {
            return this.iva;
        }

        public int setIva(int Value)
        {
            return this.iva = Value;
        }

        private int GeneratedCode()
        {
            Random random = new();
            return random.Next(1, 99999999);
        }

        private double GeneratedPrice(double Price, int Iva) 
        {
            double totalPrice = (Price * (100 + Iva)) / 100;
            return totalPrice;
        }

        private string FullName(string codeadd, string name)
        {
            return codeadd + name;
        }
    }


    //Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
    //Un prodotto è caratterizzato da:
    //-codice(numero intero)
    //- nome
    //- descrizione
    //- prezzo
    //- iva
    //Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
    //alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
    //Il codice prodotto sia accessibile solo in lettura
    //Gli altri attributi siano accessibili sia in lettura che in scrittura
    //Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    //Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
    //Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.
}
