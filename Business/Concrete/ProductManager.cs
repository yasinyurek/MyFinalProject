using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //injection yapıyoruz.
        IProductDal _prodcutDal;

        public ProductManager(IProductDal prodcutDal)
        {
            _prodcutDal = prodcutDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları,
            // yetkisi var mı?
            return _prodcutDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _prodcutDal.GetAll(p => p.CategoryId ==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _prodcutDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
