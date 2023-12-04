using System.Collections.Generic;

namespace Business.Abstract1.Single
{
    using Entity.Concrete;
    public interface ISingleService 
    {
        void Add(Single single);
        void Delete(Single single);
        List<Single> GetAll();
        List<Single> GetSingleByProjeID(int PROJEID);
        List<Single> GetSingleByAssemblyID(int AssemblyID);
        void Update(Single sevkiyat);
    }
}
