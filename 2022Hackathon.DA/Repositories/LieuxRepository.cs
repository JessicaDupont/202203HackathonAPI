using _2022Hackathon.DA.ADO;
using _2022Hackathon.DA.Mapping;
using _2022Hackathon.DA.Repositories.Bases;
using _2022Hackathon.DA.Tables;
using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2022Hackathon.DA.Repositories
{
    public class LieuxRepository : RepositoryBase, ILieuxRepository
    {
        private readonly TLieu table;
        private readonly TActCat table_join;
        private readonly MLieu map;

        public LieuxRepository() : base()
        {
            table = new TLieu();
            table_join = new TActCat();
            map = new MLieu(table);
        }

        public IEnumerable<ILieu> Read()
        {
            string requete = "select * from " + table.NomTable + " ";
            Command cmd = new Command(requete, false);
            IEnumerable<ILieu> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result;
        }

        public ILieu Read(ICategorieRepository cat, int id)
        {
            string requete = "select * from " + table.NomTable + " where "+table.IdActivite+" = "+ id;
            Command cmd = new Command(requete, false);
            ILieu result = connect.ExecuteReader(cmd, reader => map.Mapping(reader)).First();
            result.Categories = cat.Search(result);
            return result;
        }

        public IEnumerable<ILieu> Search(int categorie)
        {
            string requete = "select * from " + table.NomTable + " t " +
                "join " +table_join.NomTable+" j on j."+table_join.IdActivite+" = t."+table.IdActivite+" "+
                "where j."+table_join.IdCategorie+" = "+categorie;
            Command cmd = new Command(requete, false);
            IEnumerable<ILieu> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result;
        }
    }
}
