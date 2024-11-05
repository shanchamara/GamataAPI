namespace GamataAPI.Context
{
    public class SP_Tmp_Cart
    {
        public int CartID { get; set; }
        public int SellID { get; set; }
        public int SellerID { get; set; }
        public string Seller_Name { get; set; }
        public string product_english { get; set; }
        public string product_sinhala { get; set; }
        public string product_tamil { get; set; }
        public decimal Unit_Price { get; set; }
        public string UOM { get; set; }
        public decimal Quantity { get; set; }
        public string Image01 { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public decimal Requested_Qty { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}
