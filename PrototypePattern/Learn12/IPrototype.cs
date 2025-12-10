namespace Learn12;

public interface IPrototype<T>
{
	T Clone();
	T DeepCopy();
}
