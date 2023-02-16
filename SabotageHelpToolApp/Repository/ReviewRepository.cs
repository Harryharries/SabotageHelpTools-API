using AutoMapper;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public ICollection<Review> GetReviewsByCharacter(int characterId)
        {
            return _context.Reviews.Where(t => t.character.Id == characterId).ToList();
        }

        public Review GetReviewById(int id)
        {
            return _context.Reviews.Where(t => t.Id == id).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public bool ReviewExists(int id)
        {
            return _context.Reviews.Any(t => t.Id == id);
        }

    }
}
