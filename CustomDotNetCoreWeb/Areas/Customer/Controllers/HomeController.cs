﻿using CustomDotNetCoreWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using Web.DataAccess.Repository.IRepository;
using Web.Models.Models;

namespace CustomDotNetCoreWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IScopedGuidService _scopedGuidService1;
        private readonly IScopedGuidService _scopedGuidService2;
        private readonly ISingletonGuidService _singletonGuidService1;
        private readonly ISingletonGuidService _singletonGuidService2;
        private readonly ITransientGuidService _transientGuidService1;
        private readonly ITransientGuidService _transientGuidService2;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IScopedGuidService scopedGuidService1, IScopedGuidService scopedGuidService2,
           ISingletonGuidService singletonGuidService1, ISingletonGuidService singletonGuidService2,
           ITransientGuidService transientGuidService1, ITransientGuidService transientGuidService2, IUnitOfWork unitOfWork)
        {
            _scopedGuidService1 = scopedGuidService1;
            _scopedGuidService2 = scopedGuidService2;
            _singletonGuidService1 = singletonGuidService1;
            _singletonGuidService2 = singletonGuidService2;
            _transientGuidService1 = transientGuidService1;
            _transientGuidService2 = transientGuidService2;
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {
            //StringBuilder messages = new StringBuilder();
            //messages.Append($"Transient 1 :{_transientGuidService1.GetGuid()}\n");
            //messages.Append($"Transient 2 :{_transientGuidService2.GetGuid()}\n\n\n");
            //messages.Append($"Scoped 1 :{_scopedGuidService1.GetGuid()}\n");
            //messages.Append($"Scoped 2 :{_scopedGuidService2.GetGuid()}\n\n\n");
            //messages.Append($"Singleton 1 :{_singletonGuidService1.GetGuid()}\n");
            //messages.Append($"Singleton 2 :{_singletonGuidService2.GetGuid()}\n\n\n");
            //return Ok(messages.ToString());
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productList);
        }
		public IActionResult Details(int productId)
		{
			Product product = _unitOfWork.Product.Get(u=>u.Id== productId, includeProperties: "Category");
			return View(product);
		}
		public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}