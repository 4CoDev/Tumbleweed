using Tumbleweed.Booleans;

namespace Tumbleweed.Numerics.Integers.Natural;

public sealed class NaturalWithBits : INaturalInteger
{
	public NaturalWithBits(IEnumerable<IBoolean> bits) =>
		Bits = bits;
	
	public IEnumerable<IBoolean> Bits { get; }
}