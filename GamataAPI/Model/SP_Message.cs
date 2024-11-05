namespace GamataAPI.Context
{
    public class SP_Message
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public int ToPerson { get; set; }
        public int MessageID { get; set; }
        public DateTime InsertedOn { get; set; }
        public string Type { get; set; }
        public string NotificationType { get; set; }
    }
}
