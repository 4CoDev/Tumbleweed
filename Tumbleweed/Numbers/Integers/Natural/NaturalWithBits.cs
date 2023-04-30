using Tumbleweed.Booleans;

namespace Tumbleweed.Numbers.Integers.Natural;

public sealed class NaturalWithBits : INatural
{
	public NaturalWithBits(IEnumerable<IBoolean> bits) =>
		Bits = bits;
	
	public IEnumerable<IBoolean> Bits { get; }
}