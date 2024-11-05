using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_listing")]
    public class Listing
    {
        [Key]
        public int Code { get; set; }

        [MaxLength(200)]
        public string Image { get; set; } = "default.jpg";

        [Required]
        [Column("FK_Country_Code")]
        public string FK_Country_Code { get; set; }

        [Required]
        [Column("FK_Country_Type")]
        public string FK_Country_Type { get; set; }

        [Required]
        [Column("FK_Country_Parent")]
        public string FK_Country_Parent { get; set; }

        [ForeignKey("FK_Country_Code,FK_Country_Type,FK_Country_Parent")]
        public Country_Detail Country_Detail { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Name_Sinhala { get; set; }

        [Required]
        [Column(TypeName = "mediumtext")]
        public string Name_English { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Name_Tamil { get; set; }

        [MaxLength(500)]
        [Column("Group_of_Company")]
        public string Group_of_Company { get; set; }

        [Column("IsOutlet")]
        public bool IsOutlet { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Product_Category { get; set; }

        [MaxLength(10)]
        public string Telephone { get; set; }

        [MaxLength(10)]
        public string Whatsup { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Address { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Products_Sinhala { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Products_English { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Products_Tamil { get; set; }


        [Column(TypeName = "longtext")]
        public string Location { get; set; }

        ///additonal
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
        public int InsertedBy { get; set; }


        [Column("Status")]
        public string Status { get; set; } = "PENDING";
    }
}
