namespace DataAccess.Concrete.EntityFramework.User
{
    using DataAccess.Abstract.User;
    using Entity.Concrete;
    public class EFUserDal : EfEntityRepositoryBase<User,DataContext>, IUserDal
    {
    }
}
