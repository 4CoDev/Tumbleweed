using Tumbleweed.Booleans;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

public sealed class SingleFromBytes : ScalarEnvelope<Single>
{
	public SingleFromBytes(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new OfSystem.Singles.SingleFromBytes(
			new EnumerableWithSize<Byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}