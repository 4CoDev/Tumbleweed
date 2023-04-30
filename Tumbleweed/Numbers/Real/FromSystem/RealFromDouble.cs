using Tumbleweed.Numbers.Integers.Signed.FromSystem;
using Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles.Exponent;
using Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles.Mantissa;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.FromSystem;

public sealed class RealFromDouble : RealEnvelope
{
	public RealFromDouble(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}

	public RealFromDouble(IScalar<Double> @double) : base
	(
		new RealWithValues(
			new MantissaOfDouble(@double),
			new BaseOfDouble(),
			new ExponentOfDouble(@double))
	)
	{
	}
}