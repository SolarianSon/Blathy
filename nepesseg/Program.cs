﻿using System.IO;

namespace nepesseg
{
    internal class Program
    {

        class Orszag
        {
            public string Orszagnev { get; private set; }
            public int Terulet { get; private set; }
            public int Nepesseg { get; private set; }
            public string Fovaros { get; private set; }
            public int FovarosNepesseg { get; private set; }

            public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
            {
                Orszagnev = orszagnev;
                Terulet = terulet;
                Nepesseg = nepesseg;
                Fovaros = fovaros;
                FovarosNepesseg = fovarosNepesseg;
            }

            public Orszag(string sor)
            {
                // Ebben a konstruktorban is elvégezheti az adatsor felbontását!
                // Ha nem ezt választja, akkor törölje ezt a konstruktort!
            }

            public override string ToString()
            {
                return "";
            }

            public void Kiir()
            {
                Console.WriteLine() 
            }
        }

        Class Erettsegi
        {

        static void Main(string[] args)
        {
            int n = File.ReadAllLines("adatok-utf8.txt").Count();
            return n;
        }
    }
    }
  
}
