using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Cari adı en fazla 30 karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CariAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Cari adı en fazla 30 karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13, ErrorMessage = "Cari şehri en fazla 13 karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "Cari mail bilgisi en fazla 50 karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CariMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Cari şifre bilgisi en fazla 20 karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CariSifre { get; set; }

        public bool Durum { get; set; }

        //ilişkiler
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}