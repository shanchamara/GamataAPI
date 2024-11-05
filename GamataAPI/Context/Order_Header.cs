using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{

    [Table("t_order_header")]
    public class Order_Header
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Buyer
        /// </summary>
        [Required]
        [Column("FK_Buyer_UserID")]
        public string FK_Buyer_UserID { get; set; }

        [ForeignKey("FK_Buyer_UserID")]
        public AppUser Buyer { get; set; }

        /// <summary>
        /// seller
        /// </summary>
        [Required]
        [Column("FK_Seller_UserID")]
        public string FK_Seller_UserID { get; set; }


        [Required]
        [Column("Shipping_Address")]
        public string Shipping_Address { get; set; }

        [Required]
        [Column("Shipping_Contact")]
        public string Shipping_Contact { get; set; }

        [Required]
        [Column("Shipping_Name")]
        public string Shipping_Name { get; set; }

        [Required]
        public DateTime Order_Placed_DateTime { get; set; } = DateTime.Now;

        public DateTime Order_Confirmed_DateTime { get; set; }
        public DateTime Order_Rejected_DateTime { get; set; }
        public DateTime Order_Shipped_DateTime { get; set; }
        public DateTime Order_Delivered_DateTime { get; set; }
        public DateTime Order_Completed_DateTime { get; set; }
        public DateTime Order_Canceled_DateTime { get; set; }

        // new modification 8.6.2020
        public DateTime Order_Received_DateTime { get; set; }

        public int Buyer_Rate { get; set; } = 0;

        [Column("Comment", TypeName = "LONGTEXT")]
        public string Buyer_Comment { get; set; }

        public DateTime Buyer_RateOn { get; set; }
        /// 
        ///


        [Required]
        [Column("Status")]
        public string Status { get; set; }
        //waiting Condifrmation/Confirm/Reject/to be shipped/waiting deleviery/complete/canceled

        [Column("Cancel_Reason")]
        public string Cancel_Reason { get; set; }

        public DateTime InsertedOn { get; set; } = DateTime.Now;
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        public ICollection<Order_Detail> Order_Details { get; set; }

    }
}








