using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository()
        {
            
        }

        public async Task AddAsync(T entity)
        {

        }
    }
}
