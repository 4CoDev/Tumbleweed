using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromEnumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Mantissa;

public sealed class IsPositiveMantissa : BooleanEnvelope
{
	public IsPositiveMantissa(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}
	
	public IsPositiveMantissa(IScalar<Double> @double) : base
	(
		new LastBoolean(
			new BitsOfDouble(@double))
	)
	{
	}
}