namespace DataAccess.Models
{
    public class Story : BaseEntity
    {
        public int CreatorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Modified { get; set; }
    }
}
