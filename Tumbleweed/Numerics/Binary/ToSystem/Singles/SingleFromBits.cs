using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binary.ToSystem.Singles;

public sealed class SingleFromBits : ScalarEnvelope<float>
{
	public SingleFromBits(IEnumerable<IBit> bits) : base
	(
		new SingleFromBytes(
			new BytesFromBits(bits))
	)
	{
	}
}