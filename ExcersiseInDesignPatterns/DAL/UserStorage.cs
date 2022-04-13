using Microsoft.EntityFrameworkCore;

namespace ExcersiseInDesignPatterns.DAL
{
    public class UserStorage : IUserStorage
    {
        private readonly DemoContext _context;

        public UserStorage(DemoContext context)
        {
            _context = context;
        }

        public async Task<ICollection<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
