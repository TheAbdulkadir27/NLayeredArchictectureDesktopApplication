namespace DataAccess.Concrete.EntityFramework.Sofor
{
    using DataAccess.Abstract.Sofor;
    using Entity.Concrete;
    public class EfSoforDal : EfEntityRepositoryBase<Sofor,DataContext>, ISoforDal
    {
    }
}
