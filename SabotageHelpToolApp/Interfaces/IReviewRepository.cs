using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReviewById(int id);
        ICollection<Review> GetReviewsByCharacter(int characterId);

        bool ReviewExists(int id);

    }
}
