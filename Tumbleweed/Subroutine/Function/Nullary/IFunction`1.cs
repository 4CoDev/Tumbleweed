namespace Tumbleweed.Subroutine.Function.Nullary;

public interface IFunction<out T>
{
	T Result { get; }
}