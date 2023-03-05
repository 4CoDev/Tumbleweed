using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Natural;

public interface INaturalInteger
{
	IEnumerable<IBit> Bits { get; }
}