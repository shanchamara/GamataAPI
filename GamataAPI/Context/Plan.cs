using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_plan")]
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("Area")]
        public decimal Area { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("UOM")]
        public string UOM { get; set; }

        [Required]
        public DateTime Start_DateTime { get; set; }

        public DateTime End_DateTime { get; set; } = new DateTime(9999, 12, 31);

        [Required]
        [Column("FK_Product_Code")]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        public DateTime Inserted_DateTime { get; set; } = DateTime.Now;

        [Required]
        public DateTime Last_Updated_DateTime { get; set; } = DateTime.Now;

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;


        [Column("FK_Country_Code")]
        public string FK_Country_Code { get; set; }

        [Column("FK_Country_Type")]
        public string FK_Country_Type { get; set; }

        [Column("FK_Country_Parent")]
        public string FK_Country_Parent { get; set; }

        [ForeignKey("FK_Country_Code,FK_Country_Type,FK_Country_Parent")]
        public Country_Detail Country_Detail { get; set; }

        [Column("Seed_Code")]
        public string Seed_Code { get; set; }

        [Column("FK_Seed_Supplier_Code")]
        public int? FK_Seed_Supplier_Code { get; set; }

        [ForeignKey("FK_Seed_Supplier_Code")]
        public Supplier Seed_Supplier { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Plan_Detail> Plan_Details { get; set; }


        //[Column("FK_FL_User")]
        //public int FK_FL_User { get; set; }

        //[Column("FK_FL_Code")]
        //public string FK_FL_Code { get; set; }

        //[Column("FK_FL_Type")]
        //public string FK_FL_Type { get; set; }

        //[Column("FK_FL_Parent")]
        //public string FK_FL_Parent { get; set; }

        //[ForeignKey("FK_FL_User,FK_FL_Code,FK_FL_Type,FK_FL_Parent")]
        //public Farming_Location Farming_Location { get; set; }

        /// NOT MAPPED
        [NotMapped]
        public string Location_Description { get; set; }

    }
}