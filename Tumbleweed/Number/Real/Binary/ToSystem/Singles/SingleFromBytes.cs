using Tumbleweed._Boolean;
using Tumbleweed._Byte.ToSystem;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.ToSystem.Singles;

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