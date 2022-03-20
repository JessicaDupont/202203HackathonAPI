using System;
using System.Collections.Generic;
using System.Text;

namespace _2022HackatonAroundTheWal.Bases
{
    public interface ILieu
    {
        int IdLieu { get; set; }
        string Nom { get; set; }
        string ImageUrl { get; set; }
        string Description { get; set; }
        public double GeoLat { get; set; }
        public double GeoLong { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Localite { get; set; }
        public string SiteUrl { get; set; }
        public IEnumerable<ICategorie> Categories { get; set; }
    }
}
