namespace Domain.Entities.Catalogs
{
    public class CategoryEntity : BaseEntity
    {
        #region Ctor

        CategoryEntity() { }
        public CategoryEntity(string name)
        {
            Name = name;
        }

        #endregion

        public string Name { get; set; } = string.Empty;

        public Guid? ParentId { get; set; }
        public virtual CategoryEntity? Parent { get; set; }
    }
}