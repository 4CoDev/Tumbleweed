using Tumbleweed._Boolean;

namespace Tumbleweed.Nullable;

public interface INullable<out T>
{
	T Value { get; }
	
	IBoolean Existing { get; }
}