﻿using BethanyPieShop.Model;

namespace BethanyPieShop.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly BethanyPieShopDbContext _bethanyPieShopDbContext;
       public CategoryRepository(BethanyPieShopDbContext bethanyPieShopDbContext)
        {
            _bethanyPieShopDbContext = bethanyPieShopDbContext;
        }
        public IEnumerable<Category> AllCategories => _bethanyPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
