using Business.Abstract1.Single;
using DataAccess.Abstract.Single;
using System.Collections.Generic;

namespace Business.Concrete1.Single
{
    using Business.Utilities;
    using Business.ValidationRules1.FluentValidation.Single;
    using Entity.Concrete;
    public class SingleManager : ISingleService
    {
        private readonly ISingleDal singleDal;
        public SingleManager(ISingleDal singleDal) => this.singleDal = singleDal;
        public void Add(Single single)
        {
            ValidationTool.Validate(new SingleValidation(), single);
            singleDal.Add(single);
        }
        public void Delete(Single single)
        {
            try
            {
                singleDal.Delete(single);
            }
            catch (System.Exception)
            {
            }
        }
        public List<Single> GetAll() => singleDal.GetAll();
        public List<Single> GetSingleByAssemblyID(int AssemblyID) => singleDal.GetAll(x=>x.assemid == AssemblyID);
        public List<Single> GetSingleByProjeID(int PROJEID) => singleDal.GetAll(x=>x.pid == PROJEID);
        public void Update(Single sevkiyat)
        {
            ValidationTool.Validate(new SingleValidation(), sevkiyat);
        }
    }
}
