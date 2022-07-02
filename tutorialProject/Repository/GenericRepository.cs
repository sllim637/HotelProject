using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using tutorialProject.Data;
using tutorialProject.IRepository;

namespace tutorialProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //we make the depedancy injection od the database injection and the class that we are created
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository (DatabaseContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            //if i have the foreign key and the includes not equal tio null load it with the entity
            if (includes != null)
            {
                foreach(var includePropery in includes)
                {
                    query = query.Include(includePropery);
                }
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>,
            IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;

            //if i have the foreign key and the includes not equal tio null load it with the entity
            if (includes != null)
            {
                
                    query = query.Where(expression);
                
            }
            if (includes != null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);
                }
            }
            if(orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            // to tell that the entityt which is attached is modified
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
