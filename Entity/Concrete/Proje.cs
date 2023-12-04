using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Proje : IEntity
    {
        [Key]
        public int pid { get; set; }
        [Column(TypeName = "CHAR(20)")]
        public string pkod { get; set; }
        [Column(TypeName = "CHAR(50)")]
        public string pisim { get; set; }
        [Column(TypeName = "CHAR(50)")]
        public string paciklama { get; set; }
    }
}
