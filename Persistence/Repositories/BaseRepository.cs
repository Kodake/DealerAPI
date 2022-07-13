using Persistence.Context;

namespace Persistence.Repositories
{
    /// <summary>
    /// Base repository with all generics props to inherit in others repositories
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        /// context prop
        /// </summary>
        protected readonly AppDbContext _context;

        /// <summary>
        /// Make an instance of <see cref="BaseRepository"/>
        /// </summary>
        /// <param name="context">An instance of <see cref="AppDbContext"/></param>
        protected BaseRepository(
            AppDbContext context)
        {
            _context = context;
        }
    }
}
