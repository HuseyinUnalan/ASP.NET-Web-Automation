﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProje.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int Departmanid { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string DepartmanAdi { get; set; }
        public bool Durum { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}