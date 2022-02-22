using ServiceWCFLogicaCoches.Models;
using ServiceWCFLogicaCoches.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCFLogicaCoches
{
    public class CochesClass : ICochesContract
    {
        private RepositoryCoches repo;

        public CochesClass()
        {
            this.repo = new RepositoryCoches();
        }

        public List<Coche> GetCoches()
        {
            return this.repo.GetCoches();
        }

        public Coche FindCoche(int id)
        {
            return this.repo.FindCoche(id);
        }

        
    }
}
