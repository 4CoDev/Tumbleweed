using Tumbleweed._Boolean;

namespace Tumbleweed.Number.Integer.Natural;

public sealed class NaturalWithBits : INatural
{
	public NaturalWithBits(IEnumerable<IBoolean> bits) =>
		Bits = bits;
	
	public IEnumerable<IBoolean> Bits { get; }
}