using Company.Models.BaseEntity.Interface;

namespace Company.Models.BaseEntity;

public class BaseEntity<T> : IBaseEntity<T>
{
    public T Id { get; init; }
}