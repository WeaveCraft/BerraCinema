using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerraWebb.Pages.Admin.MovieDurations;
[BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieDuration MovieDuration { get; set; }
        public CreateModel(IUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
        
             if (ModelState.IsValid)
             {
                  _unitOfWork.MovieDuration.Add(MovieDuration);
                  _unitOfWork.Save();
                  TempData["success"] = "Category created successfully";
                  return RedirectToPage("Index");
             }
            return Page();
        }
    }
