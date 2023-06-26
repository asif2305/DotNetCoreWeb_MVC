using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor.Data;
using WebApplicationRazor.Models;

namespace WebApplicationRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly  ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db) { 
           _db = db;
        }
		public void OnGet()
        {
			CategoryList = _db.Categories.ToList();

		}
    }
}