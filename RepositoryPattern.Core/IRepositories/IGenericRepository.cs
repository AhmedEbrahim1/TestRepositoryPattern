using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
    }
}
