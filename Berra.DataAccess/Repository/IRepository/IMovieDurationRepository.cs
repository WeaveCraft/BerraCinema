using Berra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.DataAccess.Repository.IRepository
{
    public interface IMovieDurationRepository : IRepository<MovieDuration>
    {
        void Update(MovieDuration obj);


    }
}
