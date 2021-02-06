using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntity,TContex>: IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContex: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // IDisposable pattern implementation of c# = using bitti anda garbage collectore gel abi burayı temizle diyor.
            using (TContex context = new TContex())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            // tek data getirecek

            using (TContex context = new TContex())
            {
                //context.Set<Product>() : tabloyu list gibi dönmeye yarıyor.
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                // bizim için select * from product çeviriyor.
                //filtre null mı evetse tümünü getir ve listele değilse filtreyi getir ve listele
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
