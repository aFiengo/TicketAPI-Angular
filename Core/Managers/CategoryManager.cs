// using Truextend.TicketDispenser.Core.Models;

// namespace Truextend.TicketDispenser.Core.Managers;
// public class CategoryManager
// {
//     private List<Category> _categories;

//     public CategoryManager()
//     {
//         _categories = new List<Category>()
//             {
//                 new Category() {
//                     Id = 1,
//                     Name = "Music"
//                 },
//                 new Category() {
//                     Id = 2,
//                     Name = "Sport"
//                 }
//             };
//     }
//     public Category GetById(int id)
//     {
//         Category selectedCategory = _categories.Find(v => v.Id == id);
//         if (selectedCategory == null)
//         {
//             throw new Exception("Id Not Found");
//         }
//         return selectedCategory;
//     }

// }