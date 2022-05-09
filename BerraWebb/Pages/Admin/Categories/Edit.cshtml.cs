using Berra.DataAccess.Repository.IRepository;
using Berra.Dataccess.Data;
using Berra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerraWebb.Pages.Admin.Categories;
[BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Category Category { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
             Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The Display Order cannot exactly match the Name.");
        }
             if (ModelState.IsValid)
             {
                  _unitOfWork.Category.Update(Category);
                  _unitOfWork.Save();
                  TempData["success"] = "Category updated successfully";
                  return RedirectToPage("Index");
             }
            return Page();
        }
    }
