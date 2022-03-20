using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;

namespace _2022HackatonAroundTheWal
{
    public class Lieu : Bases.ILieu
    {
        public Lieu(int v)
        {
            IdLieu = v;
        }

        public string Nom { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double GeoLat { get; set; }
        public double GeoLong { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Localite { get; set; }
        public string SiteUrl { get; set; }
        public IEnumerable<ICategorie> Categories { get; set; }
        public int IdLieu { get; }
    }
}
