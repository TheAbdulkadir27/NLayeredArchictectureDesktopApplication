using Business.Abstract1.Cutting;
using Business.Utilities;
using Business.ValidationRules1.FluentValidation.Cutting;
using DataAccess.Abstract.Cutting;
using System.Collections.Generic;
namespace Business.Concrete1.Cutting
{
    using Entity.Concrete;
    public class CuttingManager : ICuttingService
    {
        private readonly ICuttingDal _cuttingDal;
        public CuttingManager(ICuttingDal cuttingDal) => _cuttingDal = cuttingDal;
        public void Add(Cutting cutting)
        {
            ValidationTool.Validate(new CuttingValidation(), cutting);
            _cuttingDal.Add(cutting);
        }
        public void Delete(Cutting cutting)
        {
            try
            {
                _cuttingDal.Delete(cutting);
            }
            catch (System.Exception)
            {

            }
        }
        public List<Cutting> GetAll() => _cuttingDal.GetAll();
        public List<Cutting> GetCuttingByProjeID(int PROJEID) => _cuttingDal.GetAll(x => x.ProjeID == PROJEID);
        public void Update(Cutting cutting)
        {
            ValidationTool.Validate(new CuttingValidation(), cutting);
            _cuttingDal.Update(cutting);
        }
    }
}
