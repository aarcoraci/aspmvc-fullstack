using ASPMVCFullStack.BusinessLogic.Managers;
using ASPMVCFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCFullStack.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index()
        {

            StorageManager manager = new StorageManager(UnitOfWork);
            Category category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Hello Category"
            };
            manager.AddCategory(category);

            return View();
        }
    }
}