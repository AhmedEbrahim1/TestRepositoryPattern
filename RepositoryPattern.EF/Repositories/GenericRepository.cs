using RepositoryPattern.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.EF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext context;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public T GetById(int id)
        {
            // we use Set<T> because we didnot know the name of table 
            return context.Set<T>().Find(id);
        }
    }
}
