using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<Int32>
{
	public MantissaSize() : base
	(
		new ScalarValue<Int32>(52)
	)
	{
	}
}