using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Sevkiyat : IEntity
    {
        [Key]
        public int sevkid { get; set; }

        [ForeignKey(nameof(proje))]
        public int pid { get; set; }
        public Proje proje { get; set; }
        public int sevkno { get; set; }
        public DateTime sevktarihi { get; set; }
        [Column(TypeName = "CHAR(25)")]
        public string pozno { get; set; }
        public int sevkadet { get; set; }

        [Column(TypeName = "CHAR(25)")]
        public string sevkkilo { get; set; }

        [Column(TypeName = "CHAR(20)")]
        public string sevktopkilo { get; set; }
        [Column(TypeName = "CHAR(20)")]
        public string paketno { get; set; }

        [Column(TypeName = "CHAR(1)")]
        public string eskisevkmi { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string konteynerno { get; set; }
    }
}
