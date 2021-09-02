using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Pepfuels.Repository.Helpers
{
    public static class LinqExtensionHelpers
    {
        public static IQueryable<T> WhereIsNotDeleted<T>(this IQueryable<T> source)
        {
            Expression<Func<T, bool>> lambda;
            try
            {
                ParameterExpression argParam = Expression.Parameter(typeof(T), "c");

                Expression nameProperty = Expression.Property(argParam, "isDelete");

                var propertyValue = Expression.Constant(false);

                Expression expr = Expression.Equal(nameProperty, propertyValue);

                lambda = Expression.Lambda<Func<T, bool>>(expr, argParam);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            return source.Where(lambda);
        }
    }
}
