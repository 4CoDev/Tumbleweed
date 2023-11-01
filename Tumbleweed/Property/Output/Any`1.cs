namespace Tumbleweed.Property.Output;

public interface Any<out T>
{
	T Value { get; }
}