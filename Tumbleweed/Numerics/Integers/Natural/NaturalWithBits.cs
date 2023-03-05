using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Natural;

public sealed class NaturalWithBits : INaturalInteger
{
	public NaturalWithBits(IEnumerable<IBit> bits) =>
		Bits = bits;
	
	public IEnumerable<IBit> Bits { get; }
}