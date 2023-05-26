using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<Int32>
{
	public MantissaSize() : base
	(
		new ScalarValue<Int32>(52)
	)
	{
	}
}