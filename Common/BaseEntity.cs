namespace SpaceAgency.Common
{
    public abstract class BaseEntity
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
