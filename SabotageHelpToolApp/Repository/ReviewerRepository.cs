using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.reviewer.Id == reviewerId).ToList();
        }

        public Reviewer GetReviewerById(int id)
        {
            return _context.Reviewers.Where(t => t.Id == id).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public bool ReviewerExists(int id)
        {
            return _context.Reviewers.Any(t => t.Id == id);
        }

    }
}
