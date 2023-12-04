using Business.Abstract1;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete1
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal) => this.categoryDal = categoryDal;
        public List<Category> GetAll()
        {
            return categoryDal.GetAll();    
        }
    }
}
