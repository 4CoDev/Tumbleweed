using Tumbleweed.Booleans;

namespace Tumbleweed.Nullables;

public interface INullable<out T>
{
	T Value { get; }
	
	IBoolean Existing { get; }
}