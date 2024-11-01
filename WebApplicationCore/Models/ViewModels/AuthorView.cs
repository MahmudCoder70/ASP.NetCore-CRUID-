using System.ComponentModel.DataAnnotations;

namespace WebApplicationCore.Models.ViewModels
{
    public class AuthorView
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        [Display(Name ="Image")]
        public IFormFile? ImagePath { get; set; }
        [Display(Name = "Status-New")]
        public bool Status { get; set; }

        public List<int > Booklist { get; set; }= new List<int>();
    }
}
