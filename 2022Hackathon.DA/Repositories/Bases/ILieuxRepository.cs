using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Repositories.Bases
{
    public interface ILieuxRepository
    {
        public IEnumerable<ILieu> Read();
        //public ILieu Read();
        public IEnumerable<ILieu> Search();
    }
}
