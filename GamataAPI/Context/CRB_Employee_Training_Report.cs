using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_employee_training_report")]
    public class CRB_Employee_Training_Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_CRB_Code")]
        public int FK_CRB_Code { get; set; }

        [ForeignKey("FK_CRB_Code")]
        public Crop_Record_Book Crop_Record_Book { get; set; }

        public string Training_Name { get; set; } = string.Empty;
        public string Time_Frame { get; set; } = string.Empty;
        public string Trainee_Name { get; set; } = string.Empty;
        public string Train_Company { get; set; } = string.Empty;
        public bool Is_Paid { get; set; } = false;

        public bool IsDeleted { get; set; } = false;
        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
