using GursagarsBooks.DataAccess.Repository.IRepository;
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
        #region API CALLS\
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
