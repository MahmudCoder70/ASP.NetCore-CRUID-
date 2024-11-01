namespace WebApplicationCore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        public virtual List<AuthorBooks> AuthorBooks { get; set; } = new List<AuthorBooks>();
    }
}
