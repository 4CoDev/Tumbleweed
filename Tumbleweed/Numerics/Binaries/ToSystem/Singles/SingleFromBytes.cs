using Tumbleweed.Bits;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.ToSystem.Singles;

public sealed class SingleFromBytes : ScalarEnvelope<float>
{
	public SingleFromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Singles.SingleFromBytes(
			new EnumerableWithSize<byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}