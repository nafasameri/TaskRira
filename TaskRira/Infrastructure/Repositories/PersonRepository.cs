using TaskRira.Domain.Repositories;
using TaskRira.Infrastructure.Persistence;

namespace TaskRira.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
