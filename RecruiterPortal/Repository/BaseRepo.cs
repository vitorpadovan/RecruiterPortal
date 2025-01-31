using Microsoft.EntityFrameworkCore;

namespace RecruiterPortal.Repository
{
    public abstract class BaseRepo<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> _dbSet;
        protected readonly AppDbContext _context;

        protected BaseRepo(AppDbContext context, Func<AppDbContext, DbSet<TEntity>> func)
        {
            _context = context;
            _dbSet = func.Invoke(context);
        }
    }
}
