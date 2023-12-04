namespace DataAccess.Concrete.EntityFramework.Cutting
{
    using DataAccess.Abstract.Cutting;
    using Entity.Concrete;
    public class EfCuttingDal : EfEntityRepositoryBase<Cutting,DataContext>, ICuttingDal
    {
    }
}
