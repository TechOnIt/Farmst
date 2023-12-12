namespace Domain.Entities.Catalogs
{
    public class PlantEntity : BaseEntity
    {
        #region Ctor

        PlantEntity() { }
        public PlantEntity(string name)
        {
            SetName(name);
        }

        #endregion

        public string Name { get; private set; } = string.Empty;
        public string? Description { get; set; }

        #region Methods

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name cannot be null.");
            Name = name;
        }

        #endregion
    }
}