using Ninject;

namespace Business.DependencyResolvers.ninject
{
    public class İnstanceFactory 
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
