
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class CategoryManager : IGenericManager<Category>
    {
        private readonly IUnitOfWork _uow;

        public CategoryManager(IUnitOfWork uow) 
        {
            _uow = uow;
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _uow.CategoryRepository.GetAllAsync();
        }
        public async Task<Category> GetById(int id)
        {
            return await _uow.CategoryRepository.GetCategoryById(id);
        }
        public async Task<Category> Create(Category categoryToAdd)
        {
            if (String.IsNullOrEmpty(categoryToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            return await _uow.CategoryRepository.CreateAsync(categoryToAdd);
        }
        public async Task<Category> Update(int id, Category categoryToUpdate)
        {
            Category categoryFound = await _uow.CategoryRepository.GetByIdAsync(id);
            if (categoryFound != null)
            {
                categoryFound.Name = categoryToUpdate.Name;
            }
            return await _uow.CategoryRepository.UpdateAsync(categoryToUpdate);
        }
        public async Task<bool> Delete(int id)
        {
            Category caegoryFound = await _uow.CategoryRepository.GetByIdAsync(id);
            await _uow.CategoryRepository.DeleteAsync(caegoryFound);
            return await _uow.CategoryRepository.GetByIdAsync(id) == null;

        }
    }
}
