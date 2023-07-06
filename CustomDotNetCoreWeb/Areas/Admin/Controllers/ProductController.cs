using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.DataAccess.Data;
using Web.DataAccess.Repository.IRepository;
using Web.Models.Models;
using Web.Models.ViewModels;

namespace CustomDotNetCoreWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        // private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll().ToList();
  			return View(objProductList);
        }
        public IActionResult Create()
        {

            ProductVM productVM = new ProductVM
			{ 
              CategoryList  = _unitOfWork.Category.GetAll().Select(
			   u => new SelectListItem
			   {
				   Text = u.Name,
				   Value = u.Id.ToString()
			   }),
              Product = new Product()
            };
			return View(productVM);
        }
        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
     
            if (ModelState.IsValid)
            {
   
                _unitOfWork.Product.Add(productVM.Product);
                _unitOfWork.Save();
                TempData["success"] = "Category created sucessfully";
                return RedirectToAction("Index", "Product");
            }
            else
            {

				productVM.CategoryList = _unitOfWork.Category.GetAll().Select(
                  u => new SelectListItem
                  {
                      Text = u.Name,
                      Value = u.Id.ToString()
                  });
					
				return View(productVM);
			}
           


        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id);
            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated sucessfully";
                return RedirectToAction("Index", "Product");
            }
            return View();


        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
             Product? categoryFromDb = _unitOfWork.Product.Get(u => u.Id == id);
           
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted sucessfully";
            return RedirectToAction("Index", "Product");

        }
    }
}
