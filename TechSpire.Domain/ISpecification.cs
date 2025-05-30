using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Domain;
public interface ISpecification <TEntity>
{
        public Expression<Func<TEntity, bool>> Criteria { get; }
        public List<Expression<Func<TEntity, Object>>> Includes { get; }
        public Expression<Func<TEntity, Object>> OrderBy { get; }
        public Expression<Func<TEntity, Object>> OrderByDesc { get; }
        public int Skip { get; }
        public int Take { get; }
        public bool IsPagingEnabled { get; }

}
