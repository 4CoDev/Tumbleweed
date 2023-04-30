using Tumbleweed.Booleans;
using Tumbleweed.Bytes;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

public sealed class SingleFromBits : ScalarEnvelope<Single>
{
	public SingleFromBits(IEnumerable<IBoolean> bits) : base
	(
		new SingleFromBytes(
			new BytesFromBits(bits))
	)
	{
	}
}