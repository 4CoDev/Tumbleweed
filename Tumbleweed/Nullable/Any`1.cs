using Tumbleweed.Boolean;

namespace Tumbleweed.Nullable;

public interface Any<out T>
{
	T Value { get; }
	
	Any HasValue { get; }
}