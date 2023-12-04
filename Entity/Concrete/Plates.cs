using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Plates : IEntity
    {
        [Key]
        public int plateID { get; set; }
        [Column(TypeName = "CHAR(25)")]
        public string plateNo { get; set; }
        [Column(TypeName = "CHAR(25)")]
        public string plateComment { get; set; }
    }
}
