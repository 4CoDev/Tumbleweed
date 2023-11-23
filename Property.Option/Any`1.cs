using Tumbleweed.Mathematics.Boolean;
using Output = Tumbleweed.Property.Output;


namespace Tumbleweed.Property.Option;

public interface Any<out T> : Output::Any<T>
{
	Any HasValue { get; }
}