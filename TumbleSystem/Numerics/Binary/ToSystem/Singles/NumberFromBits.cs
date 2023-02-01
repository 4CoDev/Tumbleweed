using TumbleSystem.Bytes;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Binary.ToSystem.Singles;

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