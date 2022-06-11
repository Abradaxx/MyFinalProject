using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;//injection

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //[Validate]
        //loglama
        //bussines codes
        //performance 
        //transaction
        //authorizition yetkilendirme
        //bu yapıları aşagı yazmak yerine
        //yukarda bu şekilde çağıracagım
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {

            //validation

            
            ValidationTool.Validate(new ProductValidator(), product);

            _productDal.Add(product);

            return new SuccesResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //postman da bakımda gözüktü bu yüzden result yapısını kullandık
            //if (DateTime.Now.Hour == 17)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}
            
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccesDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));

        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccesDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        
    }
}
