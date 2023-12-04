using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract1
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int CategoryID);
        List<Product> GetProductsByProductName(string ProductName);
        void Update(Product product);
    }
}
