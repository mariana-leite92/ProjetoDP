using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoDP.Comparer;


namespace ProjetoDP.Linq.Extension
{
    public static class DistinctExtensions
    {
        public static IEnumerable<TEntity> Distinct<TEntity>(this IEnumerable<TEntity> source, Func<TEntity, object> predicatee)
        {
            return source.Distinct(GenericComparerFactory<TEntity>.Create(predicatee));
        }
    }
}