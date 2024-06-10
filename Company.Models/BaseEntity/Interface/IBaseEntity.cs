namespace Company.Models.BaseEntity.Interface;

public interface IBaseEntity<T>
{
    public T Id { get; init; }
}