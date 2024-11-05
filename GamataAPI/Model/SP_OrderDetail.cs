namespace GamataAPI.Context
{
    public class SP_OrderDetail
    {
        public int OrderID { get; set; }
        public string Seller_name { get; set; }
        public string Seller_mobile { get; set; }
        public string Shipping_name { get; set; }
        public string Shipping_address { get; set; }
        public string Shipping_contact { get; set; }
        public DateTime Order_place_on { get; set; }
        public string ProfileImage { get; set; }
        public int SellID { get; set; }
        public string FK_Product_Code { get; set; }
        public string Name_English { get; set; }
        public string Name_Sinhala { get; set; }
        public string Name_Tamil { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public int DetailID { get; set; }
        public DateTime? Order_Placed_DateTime { get; set; }
        public DateTime? Order_Confirmed_DateTime { get; set; }
        public DateTime? Order_Rejected_DateTime { get; set; }
        public DateTime? Order_Shipped_DateTime { get; set; }
        public DateTime? Order_Delivered_DateTime { get; set; }
        public DateTime? Order_Completed_DateTime { get; set; }
        public DateTime? Order_Canceled_DateTime { get; set; }
        public string Cancel_Reason { get; set; }

        public string Js_Order_place_on
        {

            get
            {
                return Order_place_on.ToString("dd MMM yyy HH:mm:ss");
            }

        }
        public string Js_OrderID
        {
            get
            {
                return null;//BL.CommonResources.GetOrderNo(OrderID);
            }
        }

        public string Image { get; set; }
        public string UOM { get; set; }
    }
}
