using System.Collections.Generic;

namespace Business.Abstract1.Sofor
{
    using Entity.Concrete;
    public interface ISoforService 
    {
        void Add(Sofor sofor);
        void Delete(Sofor sofor);
        List<Sofor> GetAll();
        List<Sofor> GetSoforByProjeID(int PROJEID);
        List<Sofor> GetSoforBySevkNo(int SevkNo);
        void Update(Sofor sofor);
    }
}
