using _2022HackatonAroundTheWal.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.Repositories.Bases
{
    public interface ICategorieRepository
    {
        public IEnumerable<ICategorie> Read();
        public IEnumerable<ICategorie> Search(ILieu l);
    }
}
