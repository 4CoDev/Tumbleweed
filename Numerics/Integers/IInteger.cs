using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers;

public interface IInteger
{
	IBit Positive { get; }
	
	IEnumerable<IBit> Natural { get; }
}