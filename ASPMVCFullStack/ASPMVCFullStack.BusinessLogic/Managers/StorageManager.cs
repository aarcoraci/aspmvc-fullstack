using ASPMVCFullStack.BusinessLogic.Services;
using ASPMVCFullStack.DataAccess;
using ASPMVCFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.BusinessLogic.Managers
{
    public class StorageManager
    {
        public CategoryService CategoryService { get; set; }
        public ProductService ProductService { get; set; }

        public StorageManager(UnitOfWork unitOfWork)
        {
            CategoryService = new CategoryService(unitOfWork);
            ProductService = new ProductService(unitOfWork);
        }

        public void AddCategory(Category category)
        {
            CategoryService.Add(category);
            CategoryService.SaveChanges();
        }

        public void AddProductToCategory(Product product, Guid categoryId)
        {
            var category = CategoryService.GetById(categoryId);
            product.Category = category;
            ProductService.Add(product);
            ProductService.SaveChanges();
        }
    }
}
