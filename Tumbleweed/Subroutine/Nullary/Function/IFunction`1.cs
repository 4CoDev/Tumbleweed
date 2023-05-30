namespace Tumbleweed.Subroutine.Nullary.Function;

public interface IFunction<out T>
{
	T Result { get; }
}