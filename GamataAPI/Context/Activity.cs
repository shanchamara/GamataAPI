using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_activity")]
    public class Activity
    {
        [Key]
        [MaxLength(100)]
        public string Code { get; set; }

        [MaxLength(500)]
        [Column("Name_Sinhala")]
        public string Name_Sinhala { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("Name_English")]
        public string Name_English { get; set; }

        [MaxLength(500)]
        [Column("Name_Tamil")]
        public string Name_Tamil { get; set; }

        [MaxLength(100)]
        [Column("Type")]
        [DefaultValue("NON_GENERIC")]
        public string Type { get; set; }

        [MaxLength(50)]
        [Column("Icon")]
        public string Icon { get; set; }

        ///additonal
        //[Required]
        //public DateTime InsertedOn { get; set; } = DateTime.Now;
        //[Required]
        //public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        //public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Advisory> Advisories { get; set; }
        public ICollection<Plan_Detail> Plan_Details { get; set; }
        public ICollection<Product_Instruction> Product_Instructions { get; set; }

    }
}