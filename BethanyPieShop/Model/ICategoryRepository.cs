namespace BethanyPieShop.Model
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
