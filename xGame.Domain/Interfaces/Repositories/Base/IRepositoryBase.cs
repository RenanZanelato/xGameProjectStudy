using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace xGame.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        IQueryable<TEntity> ListTo(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListAndOrderByTo<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetTo(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);

        bool Exist(Func<TEntity, bool> where);

        IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> OrderByTo<TKey>(Expression<Func<TEntity, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetToId(TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity Adding(TEntity entidade);

        TEntity Update(TEntity entidade);

        void Remove(TEntity entidade);

        IEnumerable<TEntity> AddingList(IEnumerable<TEntity> entidades);
    }
}
