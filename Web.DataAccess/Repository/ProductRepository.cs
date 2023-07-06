using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DataAccess.Data;
using Web.DataAccess.Repository.IRepository;
using Web.Models.Models;

namespace Web.DataAccess.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db): base(db) { 
		  _db = db;
		}

		public void Update(Product obj)
		{
			var objFromDB = _db.Products.FirstOrDefault(x => x.Id == obj.Id);
			if (objFromDB != null)
			{
				objFromDB.Title = obj.Title;
				objFromDB.Description = obj.Description;
				objFromDB.CategoryId = obj.CategoryId;
				objFromDB.ISBN = obj.ISBN;
				objFromDB.Price = obj.Price;
				objFromDB.ListPrice = obj.ListPrice;
				objFromDB.Price50 = obj.Price50;
				objFromDB.Price100 = obj.Price100;
				objFromDB.Author = obj.Author;
				if(obj.ImageUrl != null)
				{
					objFromDB.ImageUrl = obj.ImageUrl;
				}

			}
			//_db.Products.Update(obj);
		}
	}
}
