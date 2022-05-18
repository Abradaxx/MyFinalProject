using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAcces
{
    /*Generic Constraint
     * Class: Referans Tip
     * IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir
     * new() : new lenebilir olmalı
     */
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId);

    }
}
