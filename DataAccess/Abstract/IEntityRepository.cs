using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint-kısıt
    //class :referans tip
    // IEntity: Ientity olabilir veya Ientity implemente eden bir nesne olabilir
    //new():newlenebilir olmalı yani interface soyut nesne olamaz
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
