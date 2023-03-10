using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public interface INullable<out T>
{
	T Value { get; }
	
	IBit Exists { get; }
}