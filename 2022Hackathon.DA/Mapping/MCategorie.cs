using _2022Hackathon.DA.ADO;
using _2022Hackathon.DA.Tables;
using _2022HackatonAroundTheWal.Bases;
using _2022HackatonAroundTheWal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace _2022Hackathon.DA.Mapping
{

    public class MCategorie : IMapping<DbDataReader, ICategorie>


    {
        private TCategorie table;

        public MCategorie(TCategorie table)

        {
            this.table = table;

        }
    

        public Command Mapping(ICategorie model, CRUD type)
        {
            throw new NotImplementedException();
        }

        public ICategorie Mapping(DbDataReader data)
        {
            ICategorie result = new Categorie((int)data[table.IdCategorie]);
            result.Label = data[table.Label] == DBNull.Value ? null : (string)data[table.Label];
            return result;
        }
    }
}
