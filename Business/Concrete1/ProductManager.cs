using Business.Abstract1;
using Business.Utilities;
using Business.ValidationRules1.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete1
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }
        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(),product);
            productDal.Add(product);
        }

        public void Delete(Product product)
        {

            try
            {
                productDal.Delete(product);
            }
            catch (System.Exception)
            {
                throw new System.Exception("Silme Gerçekleştirilemedi");
            }
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int CategoryID)
        {
            return productDal.GetAll(p => p.CategoryID == CategoryID);
        }

        public List<Product> GetProductsByProductName(string ProductName)
        {
            return productDal.GetAll(p => p.ProductName.ToLower().Contains(ProductName.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            productDal.Update(product);
        }
    }
}
