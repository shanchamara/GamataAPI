using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_country")]
    public class Country
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [MaxLength(100)]
        [Column("Name_Sinhala")]
        public string Name_Sinhala { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name_English")]
        public string Name_English { get; set; }

        [MaxLength(100)]
        [Column("Name_Tamil")]
        public string Name_Tamil { get; set; }

        ///additonal
        //[Required]
        //public DateTime InsertedOn { get; set; } = DateTime.Now;
        //[Required]
        //public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        //public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Country_Detail> Country_Details { get; set; }
    }
}


