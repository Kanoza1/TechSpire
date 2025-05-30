using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Services;
using TechSpire.Domain;
using TechSpire.infra.Dbcontext;

namespace TechSpire.infra;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbcontext context;

    public GenericRepository(AppDbcontext context)
    {
        this.context = context;

    }
    public void Add(T entity)
   => context.Set<T>().Add(entity);
    public async Task AddRange(List<T> entities)
    {
        await context.Set<T>().AddRangeAsync(entities);
        await context.SaveChangesAsync();
    }
    public void Delete(T entity)
           => context.Set<T>().Remove(entity);

    public async Task<T> GetEntityWithSpecification(ISpecification<T> spec)
    => await ApplySpecification(spec).FirstOrDefaultAsync();
    public async Task<List<T>> ListAsync(ISpecification<T> spec)
=> await ApplySpecification(spec).ToListAsync();



    public IQueryable<T> ApplySpecification(ISpecification<T> spec)
    => SpecificationEvaluator<T>.GetQuery(context.Set<T>().AsQueryable(), spec);
    public async Task<List<T>> GetAllAsync()
   => await context.Set<T>().ToListAsync();

    public async Task<T> GetByUserIdAsync(string id)
    => await context.Set<T>().FindAsync(id);
    public async Task<T> GetByIdAsync(int id)
    => await context.Set<T>().FindAsync(id);
    public void Update(T entity)
          => context.Set<T>().Update(entity);

    public async Task<int> CountAsync(ISpecification<T> spec)
          => await ApplySpecification(spec).CountAsync();

    public Task<int> Count()
    => context.Set<T>().CountAsync();
}
