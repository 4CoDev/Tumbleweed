using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.ToSystem.Singles;

public sealed class SingleFromBits : ScalarEnvelope<Single>
{
	public SingleFromBits(IEnumerable<IBit> bits) : base
	(
		new SingleFromBytes(
			new BytesFromBits(bits))
	)
	{
	}
}