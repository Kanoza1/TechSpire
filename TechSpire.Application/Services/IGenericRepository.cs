using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Domain;

namespace TechSpire.Application.Services;
public interface IGenericRepository <T>
{
        public Task<List<T>> ListAsync(ISpecification<T> spec);
        public Task<T> GetEntityWithSpecification(ISpecification<T> spec);

        public Task<T> GetByUserIdAsync(string id);
        public Task<T> GetByIdAsync(int id);

        public Task<int> CountAsync(ISpecification<T> spec);
        public Task<int> Count();

        public Task<List<T>> GetAllAsync();
        public void Add(T entity);
        public Task AddRange(List<T> entities);

        public void Update(T entity);
        public void Delete(T entity);

}
