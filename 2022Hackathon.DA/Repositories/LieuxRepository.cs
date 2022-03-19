using _2022Hackathon.DA.Repositories.Bases;
using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Repositories
{
    public class LieuxRepository : RepositoryBase, ILieuxRepository
    {
        public LieuxRepository() : base()
        {

        }

        public IEnumerable<ILieu> Read()
        {
            throw new NotImplementedException();
        }

        public ILieu Read(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ILieu> Search()
        {
            throw new NotImplementedException();
        }
    }
}
