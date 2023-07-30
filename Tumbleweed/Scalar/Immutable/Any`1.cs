namespace Tumbleweed.Scalar.Immutable;

public interface Any<out T>
{
	T Value { get; }
}