using GursagarsBooks.DataAccess.Repository.IRepository;
using GursagarsBooks.Models;
using GursagarBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GursagarsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepositroy
    {

        private readonly ApplicationDbContext _db;      // get the db instance using the constructor and DI 
        public ProductRepository(ApplicationDbContext db) : base(db)   // use hot keys C-T-O-R to build the constructor
        {
            _db = db;

        }
        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id); if (objFromDb !=null) // save changes if not null
            {
                if (product.ImageUrl != null)
                {


                    objFromDb.ImageUrl = product.ImageUrl;
                }

                // add the check
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;

            }
        }




    }
}
