using Business.Abstract1.Sevkiyat;
using System.Collections.Generic;

namespace Business.Concrete1.Sevkiyat
{
    using Business;
    using Utilities;
    using ValidationRules1.FluentValidation.Sevkiyat;
    using DataAccess.Abstract.Sevkiyat;
    using Entity.Concrete;

    public class SevkiyatManager : ISevkiyatService
    {
        private readonly ISevkiyatDal sevkiyatDal;
        public SevkiyatManager(ISevkiyatDal sevkiyatDal) => this.sevkiyatDal = sevkiyatDal;
        public void Add(Sevkiyat sevkiyat)
        {
            ValidationTool.Validate(new SevkiyatValidation(), sevkiyat);
            sevkiyatDal.Add(sevkiyat);
        }
        public void Delete(Sevkiyat sevkiyat)
        {
            try
            {
                sevkiyatDal.Delete(sevkiyat);
            }
            catch (System.Exception)
            {
            }
        }
        public List<Sevkiyat> GetAll() => sevkiyatDal.GetAll();
        public List<Sevkiyat> GetSevkiyatByProjeID(int PROJEID) => sevkiyatDal.GetAll(x => x.pid == PROJEID);
        public void Update(Sevkiyat sevkiyat)
        {
            ValidationTool.Validate(new SevkiyatValidation(), sevkiyat);
            sevkiyatDal.Update(sevkiyat);
        }
    }
}
