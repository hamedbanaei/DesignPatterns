namespace Abstractions;

public interface ISpecification<T>
{
	bool IsSatisfied(T t);
}
