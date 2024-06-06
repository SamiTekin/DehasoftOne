namespace DehasoftOne.Entity.BaseEntities;

public interface IBaseEntity
{
    DateTime CreatedDate { get; set; }
    Guid Id { get; set; }
}