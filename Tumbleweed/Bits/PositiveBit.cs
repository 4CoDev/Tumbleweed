using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Bits;

public sealed class PositiveBit : BitEnvelope
{
	public PositiveBit() : base
	(
		new BitFromBoolean(true)
	)
	{
	}
}