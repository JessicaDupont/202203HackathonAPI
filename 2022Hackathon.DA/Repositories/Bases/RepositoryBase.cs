using _2022Hackathon.DA.ADO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022Hackathon.DA.Repositories.Bases
{
    public abstract class RepositoryBase
    {
        private readonly string sourceDB = "Data Source=db-aroundthewal.database.windows.net;" +
            "Initial Catalog=AroundTheWal;" +
            "User ID=technof;" +
            "Password=FuturTechno$001;" +
            "Connect Timeout=30;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";
        protected readonly Connexion connect;
        protected IList<Filtre> filtres;

        public RepositoryBase()
        {
            connect = new Connexion(SqlClientFactory.Instance, sourceDB);
            InitialisationFiltres();
        }

        protected void InitialisationFiltres()
        {
            filtres = new List<Filtre>();
        }
    }
}