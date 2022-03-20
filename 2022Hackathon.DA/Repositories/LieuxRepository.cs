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
        private readonly MLieu map;

        public LieuxRepository() : base()
        {
            table = new TLieu();
            map = new MLieu(table);
        }

        public IEnumerable<ILieu> Read()
        {
            string requete = "select * from " + table.NomTable + " ";
            Command cmd = new Command(requete, false);
            IEnumerable<ILieu> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result;
        }

        public ILieu Read(int id)
        {
            string requete = "select * from " + table.NomTable + " where "+table.IdActivite+" = "+ id;
            Command cmd = new Command(requete, false);
            IEnumerable<ILieu> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            return result.First();
        }

        //TODO lieu repo search
        public IEnumerable<ILieu> Search()
        {
            throw new NotImplementedException();
        }
    }
}
