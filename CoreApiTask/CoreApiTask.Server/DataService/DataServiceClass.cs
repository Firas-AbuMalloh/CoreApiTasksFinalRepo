using CoreApiTask.Server.DTO;
using CoreApiTask.Server.IDataService;
using CoreApiTask.Server.Models;

namespace CoreApiTask.Server.DataService
{
    public class DataServiceClass : IDataServiceInterface
    {
        private readonly MyDbContext _db;
        public DataServiceClass(MyDbContext db) {

            _db = db;
        }

        public List<Category> GetAllCategories()
        {
            var categories = _db.Categories.ToList();
           
                return categories;
          
        }

        public void AddCategory(AddCategoryRequest add1)
        {
            var obj = new Category();
            obj.CategoryName = add1.CategoryName;
            obj.CategoryDescription = add1.CategoryDescription;

            _db.Categories.Add(obj);
            _db.SaveChanges();  
        }

   
        public bool UpdateCategory(int id, AddCategoryRequest newObj)
        {
            var cat = _db.Categories.Find(id);
            if (cat != null)
            {
                cat.CategoryName = newObj.CategoryName;
                cat.CategoryDescription = newObj.CategoryDescription;

                _db.Update(cat);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
