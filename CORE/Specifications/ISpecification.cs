using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CORE.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        Expression<Func<T, object>> ThenBy { get; }
        Expression<Func<T, object>> ThenByDesceding { get;}
        
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
