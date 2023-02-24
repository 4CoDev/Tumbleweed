namespace Tumbleweed.Scalars;

public interface IScalar<out T>
{
	T Value { get; }
}