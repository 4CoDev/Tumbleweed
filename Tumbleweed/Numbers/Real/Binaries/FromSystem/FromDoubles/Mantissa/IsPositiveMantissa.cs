using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles.Mantissa;

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