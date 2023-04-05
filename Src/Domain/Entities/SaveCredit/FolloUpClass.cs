namespace XOKA.Domain.Entities.SaveCredit
{
    public class FolloUpClass
    {

        public System.Guid FollowID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? Date { get; set; }
        public string FollowUpBy { get; set; }
        public string ContactNumber { get; set; }
    }
}
