using _2022Hackathon.DA.ADO;
using _2022Hackathon.DA.Tables;
using _2022HackatonAroundTheWal;
using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace _2022Hackathon.DA.Mapping
{
    public class MLieu : IMapping<DbDataReader, ILieu>
    {
        private TLieu table;

        public MLieu(TLieu table)
        {
            this.table = table;
        }

        public Command Mapping(ILieu model, CRUD type)
        {
            throw new NotImplementedException();
        }

        public ILieu Mapping(DbDataReader data)
        {
            ILieu result = new Lieu((int)data[table.IdActivite]);
            result.Nom = data[table.Nom] == DBNull.Value ? null : (string)data[table.Nom];
            result.Adresse = data[table.Adresse] == DBNull.Value ? null : (string)data[table.Adresse];
            result.CodePostal = data[table.CodePostal] == DBNull.Value ? 0 : (int)data[table.CodePostal];
            result.Description = data[table.Description] == DBNull.Value ? null : (string)data[table.Description];
            result.GeoLat = data[table.GeoLat] == DBNull.Value ? 0 : (double)data[table.GeoLat];
            result.GeoLong = data[table.GeoLong] == DBNull.Value ? 0 : (double)data[table.GeoLong];
            result.Localite = data[table.Localite] == DBNull.Value ? null : (string)data[table.Localite];
            result.ImageUrl = data[table.ImageUrl] == DBNull.Value ? null : (string)data[table.ImageUrl];
            result.SiteUrl = data[table.SiteUrl] == DBNull.Value ? null : (string)data[table.SiteUrl];
            return result;
        }
    }
}
