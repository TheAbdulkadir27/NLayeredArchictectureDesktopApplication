namespace DataAccess.Abstract.User
{
    using Entity.Concrete;
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
