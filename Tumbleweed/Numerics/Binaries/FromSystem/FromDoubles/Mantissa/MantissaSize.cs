using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<int>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<int>(52)
	)
	{
	}
}