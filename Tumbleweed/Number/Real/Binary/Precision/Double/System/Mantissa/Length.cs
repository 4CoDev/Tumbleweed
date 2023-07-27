using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa;

public sealed class Length : Scalar::Envelope<Int32>
{
	public Length() : base
	(
		new Scalar::Of.Value<Int32>(52)
	)
	{
	}
}