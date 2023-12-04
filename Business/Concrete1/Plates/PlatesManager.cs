using Business.Abstract1.Plates;
using Business.Utilities;
using Business.ValidationRules1.FluentValidation.Plates;
using DataAccess.Abstract.Plates;
using System.Collections.Generic;
namespace Business.Concrete1.Plates
{
    using Entity.Concrete;
    public class PlatesManager : IPlatesService
    {
        private readonly IPlatesDal platesDal;
        public PlatesManager(IPlatesDal platesDal) => this.platesDal = platesDal;
        public void Add(Plates plates)
        {
            ValidationTool.Validate(new PlatesValidation(), plates);
            platesDal.Add(plates);
        }
        public void Delete(Plates plates)
        {
            try
            {
                platesDal.Delete(plates);
            }
            catch (System.Exception)
            {
            }
        }
        public List<Plates> GetAll() => platesDal.GetAll();
        public void Update(Plates plates)
        {
            try
            {
                ValidationTool.Validate(new PlatesValidation(), plates);
                platesDal.Update(plates);
            }
            catch (System.Exception)
            {
            }
        }
    }
}
