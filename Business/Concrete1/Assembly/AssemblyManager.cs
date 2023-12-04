using Business.Abstract1.Assembly;
using System.Collections.Generic;
using System;
namespace Business.Concrete1.Assembly
{
    using Business.Utilities;
    using Business.ValidationRules1.Assembly;
    using DataAccess.Abstract.Assembly;
    using Entity.Concrete;
    public class AssemblyManager : IAssemblyService
    {
        private readonly IAssemblyDal assemblyDal;
        public AssemblyManager(IAssemblyDal assemblyDal) => this.assemblyDal = assemblyDal;
        public void Add(Assembly assembly)
        {
            ValidationTool.Validate(new AssemblyValidation(), assembly);
            assemblyDal.Add(assembly);
        }
        public void Delete(Assembly assembly)
        {
            try
            {
                assemblyDal.Delete(assembly);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Silme Gerçekleştirilemedi");
            }
        }
        public List<Assembly> GetAll() => assemblyDal.GetAll();
        public List<Assembly> GetAssemblyByCutNo(int CutID) => assemblyDal.GetAll(a=>a.cutno == CutID);
        public List<Assembly> GetAssemblyByProjeID(int PROJEID) => assemblyDal.GetAll(a => a.pid == PROJEID);
        public void Update(Assembly assembly)
        {
            ValidationTool.Validate(new AssemblyValidation(), assembly);
            assemblyDal.Update(assembly);
        }
    }
}
