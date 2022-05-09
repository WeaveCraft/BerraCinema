using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.DataAccess.Repository
{
    public class MovieDurationRepository : Repository<MovieDuration>, IMovieDurationRepository
    {
        private readonly ApplicationDbContext _db;

        public MovieDurationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(MovieDuration obj)
        {
            var objFromDb = _db.MovieDuration.FirstOrDefault(u => u.Id == obj.Id);
            objFromDb.Name = obj.Name;
        }
    }
}
