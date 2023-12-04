using System.Collections.Generic;
namespace Business.Abstract1.Assembly
{
    using Entity.Concrete;
    public interface IAssemblyService
    {
        void Add(Assembly assembly);
        void Delete(Assembly assembly);
        List<Assembly> GetAll();
        List<Assembly> GetAssemblyByProjeID(int PROJEID);
        List<Assembly> GetAssemblyByCutNo(int CutID);
        void Update(Assembly assembly);
    }
}
