namespace GamataAPI.Model
{
    class Notifications
    {
    }

    public class NotificationViewModel
    {
        public string Message { get; set; }
        public string Message_Sinhala { get; set; }
        public string Message_Tamil { get; set; }
        public string InsertOn { get; set; }
        public string From { get; set; }
        public string From_Img { get; set; }

        public string URL { get; set; }

        public string Type { get; set; }

        public string TypeCode { get; set; }

        public bool IsViewed { get; set; }

        //  public int Inquries { get; set; }
        // public int Sellings { get; set; }
    }



    // public class Notification

    public class MessageViewModel
    {
        public string FullName { get; set; }
        public string ImageURL { get; set; }
        public int InquiryID { get; set; }
        public string Message { get; set; }
        public InquiryJSViewModel InquiryObj { get; set; }

        public string MessageDateTime { get; set; }
    }
}
