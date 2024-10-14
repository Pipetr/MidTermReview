using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MidTermReview.Models
{
    public class Candidates
    {
        [Key]
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "First Name must be at least 4 characters long")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Last Name must be at least 4 characters long")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
