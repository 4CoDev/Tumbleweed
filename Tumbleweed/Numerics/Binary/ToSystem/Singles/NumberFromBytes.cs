using Tumbleweed.Bits;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binary.ToSystem.Singles;

public sealed class NumberFromBytes : ScalarEnvelope<float>
{
	public NumberFromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Singles.NumberFromBytes(
			new EnumerableWithSize<byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}