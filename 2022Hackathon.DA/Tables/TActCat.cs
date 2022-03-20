using _2022Hackathon.DA.Tables.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Tables
{
    public class TActCat : ITable
    {
        public string IdActivite => "Id_Act";
        public string IdCategorie => "Id_Cat";

        public string NomTable => "Lien_Act_Cat";
    }
}
