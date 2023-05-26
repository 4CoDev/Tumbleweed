namespace Tumbleweed.Scalar;

public interface IScalar<out T>
{
	T Value { get; }
}