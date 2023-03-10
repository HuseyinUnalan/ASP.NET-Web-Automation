using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProje.Models.Siniflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Urunad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(2000)]
        public string Urunbilgi { get; set; }
    }
}