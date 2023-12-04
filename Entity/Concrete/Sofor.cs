using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Sofor : IEntity
    {
        [Key]
        public int kayıtid { get; set; }
        [ForeignKey(nameof(Proje))]        
        public int pid { get; set; }
        public Proje Proje { get; set; }
        public int sevkno { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public string sevksorumlu { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string imalatsorumlu { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public string kalitesorumlu { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public string soforadi { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string sofortel { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string aracplaka { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string dorseplaka { get; set; }
        public double kantarkilo { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string konteynerno { get; set; }

        [Column(TypeName = "VARBINARY(32767)")]
        public byte[] resim { get; set; }
    }
}
