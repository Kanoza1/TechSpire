using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Application.Services;
public interface IUnitOfWork
{
        public IGenericRepository<TEntity> Repository<TEntity>();
        public Task<int> Complete();

}
