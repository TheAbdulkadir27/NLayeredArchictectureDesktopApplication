using Business.Abstract1.User;
using System.Collections.Generic;

namespace Business.Concrete1.User
{
    using Business.Utilities;
    using Business.ValidationRules1.FluentValidation.User;
    using DataAccess.Abstract.User;
    using Entity.Concrete;
    public class UserManager : IUserService
    {
        private readonly IUserDal userDal;
        public UserManager(IUserDal userDal) => this.userDal = userDal;
        public void Add(User user)
        {
            ValidationTool.Validate(new UserValidation(), user);
            userDal.Add(user);
        }

        public void Delete(User user)
        {
            try
            {
                userDal.Delete(user);
            }
            catch (System.Exception)
            {
            }
        }

        public List<User> GetAll()
        {
            return userDal.GetAll();
        }

        public void Update(User user)
        {
            ValidationTool.Validate(new UserValidation(), user);
            userDal.Update(user);
        }
    }
}
