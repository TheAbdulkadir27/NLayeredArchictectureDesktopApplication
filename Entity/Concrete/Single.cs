using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Single : IEntity
    {
        [Key]
        public int sid { get; set; }

        [ForeignKey(nameof(proje))]
        public int pid { get; set; }
        public Proje proje { get; set; }

        [ForeignKey(nameof(Assembly))]
        public int assemid { get; set; }
        public Assembly Assembly { get; set; }

        [Column(TypeName ="VARCHAR(15)")]
        public string sisim { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string sprofile { get; set; }
        public int sadet { get; set; }
        public int assemxsing { get; set; }
        public int suzunluk { get; set; }
        public double skilo { get; set; }
    }
}
