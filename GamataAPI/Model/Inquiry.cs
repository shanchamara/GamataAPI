namespace GamataAPI.Model
{
    public class Inquiry
    {
    }


    public class InquiryJSViewModel
    {
        public string Sender_Name { get; set; }
        public string Sender_Img { get; set; }

        public string Content { get; set; } = string.Empty;
    }

    public class InquiryDetail
    {
        public int UserID { get; set; }
        public string ProfileImage { get; set; }
        public string Name { get; set; }
        public string LastModification { get; set; }
        public string Message { get; set; }

        public string Type { get; set; }
    }



    public class ChatBoxViewModel
    {
        public string InqCode { get; set; }

        public MessageViewModel Message { get; set; }

    }
}
