using Tumbleweed.Booleans;

namespace Tumbleweed.Numerics.Integers.Natural;

public interface INaturalInteger
{
	IEnumerable<IBoolean> Bits { get; }
}