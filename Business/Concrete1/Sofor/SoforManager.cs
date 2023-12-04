using Business.Abstract1.Sofor;
using DataAccess.Abstract.Sofor;
using System.Collections.Generic;
namespace Business.Concrete1.Sofor
{
    using Business.Utilities;
    using Business.ValidationRules1.FluentValidation.Sofor;
    using Entity.Concrete;
    public class SoforManager : ISoforService
    {
        private readonly ISoforDal soforDal;
        public SoforManager(ISoforDal soforDal) => this.soforDal = soforDal;
        public void Add(Sofor sofor)
        {
            ValidationTool.Validate(new SoforValidation(), sofor);
            soforDal.Add(sofor);
        }
        public void Delete(Sofor sofor)
        {
            try
            {
                soforDal.Delete(sofor);
            }
            catch (System.Exception)
            {
            }
        }
        public List<Sofor> GetAll() => soforDal.GetAll();
        public List<Sofor> GetSoforByProjeID(int PROJEID) => soforDal.GetAll(x=>x.pid ==  PROJEID);
        public List<Sofor> GetSoforBySevkNo(int SevkNo) => soforDal.GetAll(x => x.sevkno == SevkNo);
        public void Update(Sofor sofor)
        {
            ValidationTool.Validate(new SoforValidation(), sofor);
            soforDal.Update(sofor);
        }
    }
}
