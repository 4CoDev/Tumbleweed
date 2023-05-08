namespace Tumbleweed.Delegates.Functions.Nullary;

public interface IFunction<out T>
{
	T Result { get; }
}