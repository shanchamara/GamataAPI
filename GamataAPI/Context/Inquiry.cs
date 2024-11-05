using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_inquiry")]
    public class Inquiry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_Sell_Code")]
        public int FK_Sell_Code { get; set; }

        [ForeignKey("FK_Sell_Code")]
        public Sell Sell { get; set; }

        public decimal Quantity { get; set; } = 0;

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Column(TypeName = "mediumtext")]
        public string InquiryInDetail { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsAccept { get; set; } = false;

        ///Additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;

        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        //Releation
        public ICollection<Inquiry_has_Message> Inquiry_has_Messages { get; set; }
    }
}
