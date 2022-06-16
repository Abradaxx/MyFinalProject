using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            //bağlımlığımı constructor injection ile yapıyorum
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            //İş Kodları
            return new SuccesDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccesDataResult<Category>(_categoryDal.Get(c=>c.CategoryId==categoryId));
        }
    }
}
