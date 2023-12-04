using Ninject.Modules;
namespace Business.DependencyResolvers.ninject
{
    using Business.Abstract1;
    using Business.Abstract1.Assembly;
    using Business.Abstract1.Cutting;
    using Business.Abstract1.Plates;
    using Business.Abstract1.Sevkiyat;
    using Business.Abstract1.Single;
    using Business.Abstract1.Sofor;
    using Business.Abstract1.User;
    using Business.Concrete1;
    using Business.Concrete1.Assembly;
    using Business.Concrete1.Cutting;
    using Business.Concrete1.Plates;
    using Business.Concrete1.Sevkiyat;
    using Business.Concrete1.Single;
    using Business.Concrete1.Sofor;
    using Business.Concrete1.User;
    using DataAccess.Abstract;
    using DataAccess.Abstract.Assembly;
    using DataAccess.Abstract.Cutting;
    using DataAccess.Abstract.Plates;
    using DataAccess.Abstract.Sevkiyat;
    using DataAccess.Abstract.Single;
    using DataAccess.Abstract.Sofor;
    using DataAccess.Abstract.User;
    using DataAccess.Concrete.EntityFramework;
    using DataAccess.Concrete.EntityFramework.Assembly;
    using DataAccess.Concrete.EntityFramework.Cutting;
    using DataAccess.Concrete.EntityFramework.Plates;
    using DataAccess.Concrete.EntityFramework.Sevkiyat;
    using DataAccess.Concrete.EntityFramework.Single;
    using DataAccess.Concrete.EntityFramework.Sofor;
    using DataAccess.Concrete.EntityFramework.User;

    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IAssemblyService>().To<AssemblyManager>().InSingletonScope();
            Bind<IAssemblyDal>().To<EFAssemblyDal>().InSingletonScope();

            Bind<ICuttingService>().To<CuttingManager>().InSingletonScope();
            Bind<ICuttingDal>().To<EfCuttingDal>().InSingletonScope();

            Bind<IPlatesService>().To<PlatesManager>().InSingletonScope();
            Bind<IPlatesDal>().To<EFPlatesDal>().InSingletonScope();

            Bind<ISevkiyatService>().To<SevkiyatManager>().InSingletonScope();
            Bind<ISevkiyatDal>().To<EFSevkiyatDal>().InSingletonScope();

            Bind<ISingleService>().To<SingleManager>().InSingletonScope();
            Bind<ISingleDal>().To<EFSingleDal>().InSingletonScope();

            Bind<ISoforService>().To<SoforManager>().InSingletonScope();
            Bind<ISoforDal>().To<EfSoforDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EFUserDal>().InSingletonScope();
        }
    }
}
