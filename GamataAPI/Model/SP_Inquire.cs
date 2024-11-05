namespace GamataAPI.Context
{
    public class SP_Inquire
    {
        public int Code { get; set; }
        public int FK_Sell_Code { get; set; }
        public decimal Requested_Quantity { get; set; }
        public string InquiryInDetail { get; set; }
        public DateTime LastModifiedOn { get; set; }

        public string LastModifiedOn_formated { get; set; }
        public int Requested_User_ID { get; set; }
        public string Requested_User_Name { get; set; }
        public string Requesterd_User_Image { get; set; }
        public int Seller_User_ID { get; set; }
        public string Seller_User_Name { get; set; }
        public string Seller_User_Image { get; set; }
        public string FK_Product_Code { get; set; }
        public string Product_Name_English { get; set; }
        public string Product_Name_Sinhala { get; set; }
        public string Product_Name_Tamil { get; set; }

        public System.Int64 Unread_Messages { get; set; }
    }
}
