namespace Learn09;

//public interface ICloneable<T>
//{
//    T Clone();
//}

//public interface IPrototype<T> : ICloneable<T>
//{
//    T DeepCopy();
//}

public interface IPrototype<T>
{
	T Clone();
	T DeepCopy();
}
