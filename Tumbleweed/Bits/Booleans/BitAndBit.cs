using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Bits.OfSystem;

namespace Tumbleweed.Bits.Booleans;

public sealed class BitAndBit : BitEnvelope
{
	public BitAndBit(IBit first, IBit second) : base
	(
		new BitFromBoolean(
			new BooleanOfFunction(
				() => first.State && second.State))
	)
	{
	}
}