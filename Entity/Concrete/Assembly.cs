using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Assembly : IEntity
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="CHAR(15)")]
        public string assemkod { get; set; }
        public int assemadet { get; set; }
        public double assemkilo { get; set; }

        [ForeignKey(nameof(Proje))]
        public int pid { get; set; }
        public Proje Proje { get; set; }


        [Column(TypeName ="VARCHAR(10)")]
        public string P00 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P05 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P06 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P08 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P10 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P12 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P15 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P20 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P25 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P30 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P35 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P40 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P45 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P50 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P55 { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string P60 { get; set; }

        [ForeignKey("Cutting")]
        public int cutno { get; set; }
        public Cutting Cutting { get; set; }
        public DateTime cutdate { get; set; }
        [Column(TypeName ="CHAR(20)")]
        public string comment { get; set; }
        [Column(TypeName = "CHAR(20)")]
        public string meterialtype { get; set; }
        public int sevkadet { get; set; }

        [Column(TypeName = "CHAR(20)")]
        public string sevkkilo { get; set; }
    }
}
