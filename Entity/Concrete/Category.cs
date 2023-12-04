using Entity.Abstract;

namespace Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
