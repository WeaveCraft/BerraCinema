using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerraWebb.Pages.Admin.MovieDurations
{
    public class IndexModel : PageModel
    {
            private readonly IUnitOfWork _unitOfWork;
            public IEnumerable<MovieDuration> MovieDurations { get; set; }
            public IndexModel(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
        public void OnGet()
        {
            MovieDurations = _unitOfWork.MovieDuration.GetAll();
        }
    }
}
