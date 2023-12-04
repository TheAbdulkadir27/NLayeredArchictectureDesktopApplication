namespace DataAccess.Concrete.EntityFramework.Proje
{
    using DataAccess.Abstract.Proje;
    using Entity.Concrete;
    public class EFProjeDal : EfEntityRepositoryBase<Proje,DataContext>, IProjeDal
    {
    }
}
