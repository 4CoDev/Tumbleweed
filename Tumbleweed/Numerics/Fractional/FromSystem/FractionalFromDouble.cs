using Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Exponent;
using Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Mantissa;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalFromDouble : FractionalEnvelope
{
	public FractionalFromDouble(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}

	public FractionalFromDouble(IScalar<Double> @double) : base
	(
		new FractionalWithValues(
			new MantissaOfDouble(@double),
			new BaseOfDouble(),
			new ExponentOfDouble(@double))
	)
	{
	}
}