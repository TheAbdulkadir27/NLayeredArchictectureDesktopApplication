namespace DataAccess.Concrete.EntityFramework.Plates
{
    using DataAccess.Abstract.Plates;
    using Entity.Concrete;
    public class EFPlatesDal : EfEntityRepositoryBase<Plates,DataContext>,IPlatesDal
    {
    }
}
