﻿using System.Linq.Expressions;

namespace MINEDU.IEST.Estudiante.Repository.Base
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        void Delete(object id);
        void Delete(object[] keyValues);
        void Delete(TEntity entityToDelete);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        List<TEntity> GetAllTake(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", int PageSize= 10);
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
