namespace LearnFlow.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        public Guid Id { get; set; }
    }
}
