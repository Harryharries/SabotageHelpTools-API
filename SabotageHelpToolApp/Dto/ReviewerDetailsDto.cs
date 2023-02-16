using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Dto
{
    public class ReviewerDetailsDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<ReviewDto>? Reviews { get; set; }
    }
}
