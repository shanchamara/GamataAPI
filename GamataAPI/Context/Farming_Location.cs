using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_farming_location")]
    public class Farming_Location
    {
        [Key]
        [Column("Code")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        [Column("Name"), MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser User { get; set; }

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

        public bool IsDeleted { get; set; } = false;

        public decimal Area { get; set; } = 0.00m;
        public string Area_Unit { get; set; } = string.Empty;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }


    }
}