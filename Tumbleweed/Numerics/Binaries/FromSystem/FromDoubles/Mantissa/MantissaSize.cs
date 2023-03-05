using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<Int32>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<Int32>(52)
	)
	{
	}
}