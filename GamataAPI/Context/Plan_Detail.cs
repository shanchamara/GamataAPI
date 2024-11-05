using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_plan_detail")]
    public class Plan_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_PlanID")]
        public int FK_PlanID { get; set; }

        [ForeignKey("FK_PlanID")]
        public Plan Plans { get; set; }

        //[Key, Column("FK_Supplier_Item_Code", Order = 1)]
        //public string FK_Supplier_Item_Code { get; set; }

        //[Key, Column("FK_Supplier_Code", Order = 2)]
        //public string FK_Supplier_Code { get; set; }

        //[ForeignKey("FK_Supplier_Item_Code,FK_Supplier_Code")]
        //public Supplier_Item Supplier_Item { get; set; }

        [Required]
        [Column("FK_Activity")]
        public string FK_Activity { get; set; }

        [ForeignKey("FK_Activity")]
        public Activity Activities { get; set; }

        public int Start_Duration { get; set; }

        public int End_Duration { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
    }
}