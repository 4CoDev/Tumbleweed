using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binary.ToSystem.Singles;

public sealed class NumberFromBits : ScalarEnvelope<float>
{
	public NumberFromBits(IEnumerable<IBit> bits) : base
	(
		new NumberFromBytes(
			new BytesFromBits(bits))
	)
	{
	}
}