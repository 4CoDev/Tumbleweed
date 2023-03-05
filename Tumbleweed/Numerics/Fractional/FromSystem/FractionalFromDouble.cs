using Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Exponent;
using Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalFromDouble : FractionalEnvelope
{
	public FractionalFromDouble(double @double) : this
	(
		new ScalarOfValue<double>(@double)
	)
	{
	}

	public FractionalFromDouble(IScalar<double> @double) : base
	(
		new FractionalWithValues(
			new MantissaOfDouble(@double),
			new BaseOfDouble(),
			new ExponentOfDouble(@double))
	)
	{
	}
}