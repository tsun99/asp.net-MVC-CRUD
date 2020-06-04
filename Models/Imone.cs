using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netMVCCRUD.Models
{
    public class Imone
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "Šis laukas negali būti tuščias")]
        
        public string Pavadinimas { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("El. Paštas")]
        public string ElPastas { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("Blogas El. Paštas")]
        public string BlogasElPastas { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Kontaktinis Tel.Nr")]
        public string TelNr { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Apskritis { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string VMVT { get; set; }
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Kita Info")]
        public string KitaInfo { get; set; }
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Aktuali Veikla")]
        public string AktualiVeikla { get; set; }
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Įmonės Kodas")]
        public string ImonesKodas { get; set; }

    }
}
