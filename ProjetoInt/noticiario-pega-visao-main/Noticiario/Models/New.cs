using System.ComponentModel.DataAnnotations;

namespace Noticiario.Models
{
    public class New
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; }
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        [Display(Name = "Data")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Date { get; set; }
        [Display(Name = "Local")]
        public string Location { get; set; }

        public New()
        {

        }

        public New(int id, string title, string category, DateTime date, string location)
        {
            Id = id;
            Title = title;
            Category = category;
            Date = date;
            Location = location;
        }
    }
}
