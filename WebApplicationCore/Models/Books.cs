namespace WebApplicationCore.Models
{
    public class Books
    {
        public int BooksId { get; set; }
        public string BookName { get; set; }

        public virtual List<AuthorBooks> AuthorBooks { get; set; } = new List<AuthorBooks>();
    }
}
