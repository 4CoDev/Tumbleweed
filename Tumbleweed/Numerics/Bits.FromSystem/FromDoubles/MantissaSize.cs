using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromDoubles;

public sealed class MantissaSize : ScalarEnvelope<int>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<int>(52)
	)
	{
	}
}