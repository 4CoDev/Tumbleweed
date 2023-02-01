using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Bits.FromEnumerable;

public sealed class LastBit : BitEnvelope
{
	public LastBit(IEnumerable<IBit> enumerable) : base
	(
		new BitOfScalar(
			new LastScalar<IBit>(enumerable))
	)
	{
	}
}