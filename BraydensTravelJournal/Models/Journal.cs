using System.ComponentModel.DataAnnotations;

namespace BraydensTravelJournal.Models
{
    public class Journal
    {
        public int Id { get; set; } = 0;

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [MaxLength(50)]
        [MinLength(1)]
        public string Name { get; set; } = default!;


        [Required]
        [MaxLength(1000)]
        [MinLength(1)]
        public string Description { get; set; } = default!;


        public bool IsVisited { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [MinLength(1)]
        public string address { get; set; } = default!;


        public DateTime VisitDate { get; set; }

        [Required]
        [Range(0, 100)]
        public int TimesVisited { get; set; } = 0;


        public bool VisitAgain { get; set; }

    }
}
