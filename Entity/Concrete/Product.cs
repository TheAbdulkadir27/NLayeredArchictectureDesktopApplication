using Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        //[Column(TypeName = "VARBINARY(MAX)")]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitİnStock { get; set; }
    }
}
