using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCore.Models
{
    public class AuthorBooks
    {
        public int AuthorBooksId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Books")]
        public int BooksId { get; set; }


        public virtual Author? Author { get; set; }
        public virtual Books? Books { get; set; }

    }
}
