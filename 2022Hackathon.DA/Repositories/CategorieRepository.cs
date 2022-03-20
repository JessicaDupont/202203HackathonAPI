using _2022Hackathon.DA.ADO;
using _2022Hackathon.DA.Mapping;
using _2022Hackathon.DA.Repositories.Bases;
using _2022Hackathon.DA.Tables;
using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Repositories
{
    public class CategorieRepository : RepositoryBase, ICategorieRepository
    {
        private readonly TCategorie table;
        private readonly TActCat table_join;
        private readonly MCategorie map;

        public CategorieRepository(): base()
        {
            table = new TCategorie();
            table_join = new TActCat();
            map = new MCategorie(table);
        }
        public IEnumerable<ICategorie> Read()
        {
            string requete = "select * from " + table.NomTable + " ";
            Command cmd = new Command(requete, false);
            IEnumerable<ICategorie> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result;
        }

        public IEnumerable<ICategorie> Search(ILieu l)
        {
            string requete = "select * from " + table.NomTable + " t  " +
                "join "+table_join.NomTable+" j on j."+table_join.IdCategorie+" = t."+table.IdCategorie+" " +
                "where "+table_join.IdActivite+" = "+l.IdLieu;
            Command cmd = new Command(requete, false);
            IEnumerable<ICategorie> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result;
        }
    }
}
