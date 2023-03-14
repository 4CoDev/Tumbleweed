using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Bits;

public sealed class NegativeBit : BitEnvelope
{
	public NegativeBit() : base
	(
		new BitFromBoolean(false)
	)
	{
	}
}