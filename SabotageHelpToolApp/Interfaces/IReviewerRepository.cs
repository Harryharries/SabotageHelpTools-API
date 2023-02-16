using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();

        Reviewer GetReviewerById(int id);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);

        bool ReviewerExists(int id);

    }
}
