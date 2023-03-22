using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public interface INullable<out T> where T : notnull
{
	T Value { get; }
	
	IBit Exists { get; }
}