namespace GamataAPI.Context
{
    public class SP_UserOrder
    {

        public int OrderID { get; set; }

        public string Js_OrderID
        {
            get
            {
                return null;// BL.CommonResources.GetOrderNo(OrderID);
            }
        }
        public int Seller_Code { get; set; }
        public int BuyerID { get; set; }
        public int SellerID { get; set; }
        public string Seller_name { get; set; }
        public string Seller_mobile { get; set; }
        public string Shipping_name { get; set; }
        public string Shipping_address { get; set; }
        public string Shipping_contact { get; set; }
        public decimal Total { get; set; }
        public int Items { get; set; }
        public string Status { get; set; }
        public DateTime Order_place_on { get; set; }

        public string Js_Order_place_on
        {

            get
            {
                return Order_place_on.ToString("dd MMM yy HH:mm");
            }

        }

        public string Js_Order_Delivered_DateTime
        {

            get
            {
                return (Order_Delivered_DateTime != null) ? ((DateTime)Order_Delivered_DateTime).ToString("dd MMM yy HH:mm") : "";
            }

        }



        public string ProfileImage { get; set; }
        //public DateTime? Order_Placed_DateTime { get; set; }
        //public DateTime? Order_Confirmed_DateTime { get; set; }
        //public DateTime? Order_Rejected_DateTime { get; set; }
        //public DateTime? Order_Shipped_DateTime { get; set; }
        //public DateTime? Order_Delivered_DateTime { get; set; }
        //public DateTime? Order_Completed_DateTime { get; set; }
        //public DateTime? Order_Canceled_DateTime { get; set; }
        public string Cancel_Reason { get; set; }

        public DateTime? Order_Placed_DateTime { get; set; }
        public DateTime? Order_Confirmed_DateTime { get; set; }
        public DateTime? Order_Rejected_DateTime { get; set; }
        public DateTime? Order_Shipped_DateTime { get; set; }
        public DateTime? Order_Delivered_DateTime { get; set; }
        public DateTime? Order_Completed_DateTime { get; set; }
        public DateTime? Order_Canceled_DateTime { get; set; }
        public DateTime? Order_Received_DateTime { get; set; }
        public DateTime? Buyer_RateOn { get; set; }
        public string Comment { get; set; }
        public int Buyer_Rate { get; set; }

    }
}
