using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerraWebb.Pages.Admin.MovieDurations;
[BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieDuration MovieDuration { get; set; }
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            MovieDuration = _unitOfWork.MovieDuration.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
                  var movieDuration = _unitOfWork.MovieDuration.GetFirstOrDefault(u => u.Id == MovieDuration.Id);
                  if (movieDuration != null)
                  {
                      _unitOfWork.MovieDuration.Remove(movieDuration);
                      _unitOfWork.Save();
                      TempData["success"] = "MovieDuration deleted successfully";
                      return RedirectToPage("Index");
                  }
            return Page();
        }
    }
