using Tumbleweed.Booleans;

namespace Tumbleweed.Nullability;

public interface INullable<out T>
{
	T Value { get; }
	
	IBoolean Existing { get; }
}