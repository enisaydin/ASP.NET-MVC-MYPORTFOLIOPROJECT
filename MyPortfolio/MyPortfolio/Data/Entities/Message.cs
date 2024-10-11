namespace MyPortfolio.Data.Entities
{
    public class Message
    {
        public string MessageId {  get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDeteail { get; set; }
        public DateTime SendDate { get; set; }
    }
}
