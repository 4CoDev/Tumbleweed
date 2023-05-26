using Tumbleweed._Boolean;
using Tumbleweed._Byte;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.ToSystem.Singles;

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