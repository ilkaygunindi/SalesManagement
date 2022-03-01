using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            //default categories
            categories = new List<Category>()
            {
                new Category { CategoryId =1, CategoryName = "Kick Scooter", CategoryDescription = "Kick Scooter"},
                new Category { CategoryId =2, CategoryName = "Scooter", CategoryDescription = "Scooter"},
                new Category { CategoryId =3, CategoryName = "EBike", CategoryDescription = "EBike"},
            };

        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.CategoryName.Equals(category.CategoryName, StringComparison.OrdinalIgnoreCase))) return;
            
            if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.CategoryDescription = category.CategoryDescription;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
