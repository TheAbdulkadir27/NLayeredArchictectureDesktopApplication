using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int userID { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string UserPass { get; set; }
        public int UserLevel { get; set; }
    }
}
