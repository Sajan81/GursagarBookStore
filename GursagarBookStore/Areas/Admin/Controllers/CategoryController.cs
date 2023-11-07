using GursagarsBooks.DataAccess.Repository.IRepository;
using GursagarsBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GursagarBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitofWork)
        {
            _unitOfWork = unitofWork;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) // action method for uppsert
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);

            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category  == null)
            {
                return NotFound();
            }
            return View(category);
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
