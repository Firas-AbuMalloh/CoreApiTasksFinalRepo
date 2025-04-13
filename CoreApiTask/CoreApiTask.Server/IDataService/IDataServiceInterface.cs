using CoreApiTask.Server.DTO;
using CoreApiTask.Server.Models;

namespace CoreApiTask.Server.IDataService
{
    public interface IDataServiceInterface
    {
        public List<Category> GetAllCategories();

        public void AddCategory(AddCategoryRequest add1);

        // Use bool for return type to indicate whether the update was successful
        public bool UpdateCategory(int id, AddCategoryRequest newObj);
    }
}
