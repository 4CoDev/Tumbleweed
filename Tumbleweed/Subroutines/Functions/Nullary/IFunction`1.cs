namespace Tumbleweed.Subroutines.Functions.Nullary;

public interface IFunction<out T>
{
	T Result { get; }
}