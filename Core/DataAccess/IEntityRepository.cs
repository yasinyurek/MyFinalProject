using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
        //Genericconstraint : generic kısıtlama
        //where T:calss,yani refarans tip olabilir demektir. Yani aramaları kısıtladık. int vb veremezler. 
        //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
        //new(): newlenebilir olmalıdır. Bu şekilde bir abstract olan IEntity nin kendisini devre dışı bıraktık.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    

    }
}
