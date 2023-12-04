namespace Business.Abstract1.Sevkiyat
{
    using Entity.Concrete;
    using System.Collections.Generic;

    public interface ISevkiyatService
    {
        void Add(Sevkiyat sevkiyat);
        void Delete(Sevkiyat sevkiyat);
        List<Sevkiyat> GetAll();
        List<Sevkiyat> GetSevkiyatByProjeID(int PROJEID);
        void Update(Sevkiyat sevkiyat);
    }
}
