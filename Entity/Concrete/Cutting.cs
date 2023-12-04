using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
    public class Cutting : IEntity
    {
        [Key]
        public int cutid { get; set; }
        public DateTime cutdate { get; set; }
        [ForeignKey(nameof(pid))]
        public int ProjeID { get; set; }
        public Proje pid { get; set; }
        [Column(TypeName ="CHAR(15)")]
        public string profile { get; set; }
        [Column(TypeName = "CHAR(20)")]
        public string comment { get; set; }
        [Column(TypeName = "CHAR(15)")]
        public string assemkod { get; set; }
        [Column(TypeName = "CHAR(15)")]
        public string single { get; set; }
        public int cutqty { get; set; }
        public int cutno { get; set; }
        [Column(TypeName = "CHAR(25)")]
        public string skilo { get; set; }
    }
}
