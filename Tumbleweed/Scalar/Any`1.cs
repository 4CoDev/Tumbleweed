namespace Tumbleweed.Scalar;

public interface Any<out T>
{
	T Value { get; }
}