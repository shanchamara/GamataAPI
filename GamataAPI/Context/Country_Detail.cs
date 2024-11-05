using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_country_detail")]
    public class Country_Detail
    {

        [Key, Column(Order = 0)]
        [MaxLength(100)]
        public string Code { get; set; }


        [Key, Column(Order = 1)]
        [MaxLength(3)]
        public string Type { get; set; }

        [Key, Column(Order = 2)]
        [MaxLength(100)]
        public string Parent { get; set; }

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

        [Column("FK_Country_Code")]
        public string FK_Country_Code { get; set; }

        [ForeignKey("FK_Country_Code")]
        public Country Country { get; set; }





        ///additonal
        //[Required]
        //public DateTime InsertedOn { get; set; } = DateTime.Now;
        //[Required]
        //public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        //public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Farming_Location> Farming_Locations { get; set; }
        public ICollection<Plan> Plans { get; set; }
        public ICollection<Sell> Sells { get; set; }
    }
}