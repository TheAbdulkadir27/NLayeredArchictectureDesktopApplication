using DataAccess.Abstract.Sevkiyat;

namespace DataAccess.Concrete.EntityFramework.Single
{
    using DataAccess.Abstract.Single;
    using Entity.Concrete;
    public class EFSingleDal : EfEntityRepositoryBase<Single, DataContext>, ISingleDal
    {
    }
}
