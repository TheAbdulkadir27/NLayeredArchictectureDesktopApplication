using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract1
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
