using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022HackatonAroundTheWal
{
    public class Categorie : ICategorie
    {

        public Categorie(int v)
        {
            IdCategorie = v;
        }

        public string Label { get ; set ; }
        public int IdCategorie { get ; set ; }
    }
}
