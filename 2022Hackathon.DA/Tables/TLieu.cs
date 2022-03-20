using _2022Hackathon.DA.Tables.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Tables
{
    public class TLieu : ITable
    {

        public string IdActivite => "Id_Activite";
        public string Nom => "Nom";
        public string ImageUrl => "Image";
        public string Description => "Description";
        public string GeoLat => "Lat";
        public string GeoLong => "Long";
        public string Adresse => "Adresse";
        public string CodePostal => "CodePostal";
        public string Localite => "Ville";
        public string SiteUrl => "Url";

        public string NomTable => "Activite";
    }
}
