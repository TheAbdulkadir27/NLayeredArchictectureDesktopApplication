namespace DataAccess.Concrete.EntityFramework.Assembly
{
    using DataAccess.Abstract.Assembly;
    using Entity.Concrete;
    public class EFAssemblyDal : EfEntityRepositoryBase<Assembly,DataContext>, IAssemblyDal
    {
    }
}
