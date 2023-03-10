using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProje.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Display(Name = "Personel Adı")]
        public string PersonelAd { get; set; }
        [Display(Name = "Personel Soyadı")]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string PersonelSoyad { get; set; }
        [Column(TypeName = "varchar")]
        [Display(Name = "Görsel")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int Departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}