using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_supplier")]
    public class Supplier
    {

        [Key, Column("Code"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

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

        [MaxLength(5000)]
        [Column("Address")]
        public string Address { get; set; }

        [MaxLength(10)]
        [Column("Contact_No1")]
        public string Contact_No1 { get; set; }

        [MaxLength(10)]
        [Column("Contact_No2")]
        public string Contact_No2 { get; set; }

        [MaxLength(200)]
        [Column("Email")]
        public string Email { get; set; }


        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Supplier_Item> Supplier_Items { get; set; }
        public ICollection<Plan> Plans { get; set; }


    }
}