using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProje.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter girebilirsin.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsin.")]
        public String CariAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter girebilirsin.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsin.")]
        public String CariSoyad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(13, ErrorMessage = "En fazla 13 karakter girebilirsin.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsin.")]
        public String CariSehir { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]

        public String CariMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CariSifre { get; set; }
        public bool Durum { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}