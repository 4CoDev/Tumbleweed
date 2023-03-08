using Tumbleweed.Bits;

namespace Tumbleweed.Existence;

public interface IExistence<out T>
{
	T Value { get; }
	
	IBit Exists { get; }
}