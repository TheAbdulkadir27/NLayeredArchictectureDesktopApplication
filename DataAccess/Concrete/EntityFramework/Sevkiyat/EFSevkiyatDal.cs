using DataAccess.Abstract.Sevkiyat;
namespace DataAccess.Concrete.EntityFramework.Sevkiyat
{
    using Entity.Concrete;
    public class EFSevkiyatDal : EfEntityRepositoryBase<Sevkiyat, DataContext>, ISevkiyatDal
    {
    }
}
