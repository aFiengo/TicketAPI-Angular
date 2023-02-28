
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class CategoryManager
    {
        private List<Category> _categories;
        
        public CategoryManager() 
        {
            _categories = new List<Category>()
            {
                new Category(){ Id = 1, Name = "Music"},
                new Category(){ Id = 2, Name = "Sport"}
            };
        }
        public List<Category> GetCategories()
        {
            return _categories;
        }
        public Category AddCategory(Category categoryToAdd)
        {
            if (String.IsNullOrEmpty(categoryToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            _categories.Add(categoryToAdd);
            return categoryToAdd;
        }
        public Category UpdateCategory(int id, Category categoryToUpdate)
        {
            Category category = _categories.FirstOrDefault(z => z.Id == id);
            if (category != null)
            {
                category.Name = categoryToUpdate.Name;
            }
            return categoryToUpdate;

        }
        public Category DeleteCategory(int id)
        {
            Category categoryFound = _categories.Find(z => z.Id == id);
            _categories.Remove(categoryFound);
            return categoryFound;
        }
        public Category GetById(int id)
        {
            Category selectedCategory = _categories.Find(z => z.Id == id);
            if (selectedCategory == null)
            {
                throw new Exception("Id Not Found");
            }
            return selectedCategory;
        }
    }
}
