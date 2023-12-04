using System.Collections.Generic;

namespace Business.Abstract1.Proje
{
    using Entity.Concrete;
    public interface IProjeService
    {
        void Add(Proje proje);
        void Delete(Proje proje);
        List<Proje> GetAll();
        void Update(Proje proje);
    }
}
