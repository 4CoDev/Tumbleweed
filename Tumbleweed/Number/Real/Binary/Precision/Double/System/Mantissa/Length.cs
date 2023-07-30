using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa;

public sealed class Length : Envelope<Int32>
{
	public Length() : base
	(
		new Value<Int32>(52)
	)
	{
	}
}