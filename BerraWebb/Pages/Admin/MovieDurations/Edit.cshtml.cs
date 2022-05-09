using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerraWebb.Pages.Admin.MovieDurations;
[BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieDuration MovieDuration { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    public void OnGet(int id)
        {
             MovieDuration = _unitOfWork.MovieDuration.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
        
             if (ModelState.IsValid)
             {
                  _unitOfWork.MovieDuration.Update(MovieDuration);
                  _unitOfWork.Save();
                  TempData["success"] = "Category updated successfully";
                  return RedirectToPage("Index");
             }
            return Page();
        }
    }
