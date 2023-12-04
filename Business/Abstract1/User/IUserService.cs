using System.Collections.Generic;

namespace Business.Abstract1.User
{
    using Entity.Concrete;
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        List<User> GetAll();
        void Update(User user);
    }
}
