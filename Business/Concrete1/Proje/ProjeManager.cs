using Business.Abstract1.Proje;
using DataAccess.Abstract.Proje;
using System.Collections.Generic;
namespace Business.Concrete1.Proje
{
    using Business.Utilities;
    using Business.ValidationRules1.FluentValidation.Proje;
    using Entity.Concrete;
    public class ProjeManager : IProjeService
    {
        private readonly IProjeDal _projedal;
        public ProjeManager(IProjeDal projedal) => _projedal = projedal;
        public void Add(Proje proje)
        {
            ValidationTool.Validate(new ProjeValidation(), proje);
            _projedal.Add(proje);
        }
        public void Delete(Proje proje)
        {
            try
            {
                _projedal.Delete(proje);
            }
            catch (System.Exception)
            {
            }
        }
        public List<Proje> GetAll() => _projedal.GetAll();
        public void Update(Proje proje)
        {
            ValidationTool.Validate(new ProjeValidation(), proje);
            _projedal.Update(proje);
        }
    }
}
