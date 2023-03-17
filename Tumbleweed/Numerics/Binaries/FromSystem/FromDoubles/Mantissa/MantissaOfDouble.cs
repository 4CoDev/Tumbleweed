using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaOfDouble : SignedEnvelope
{
	public MantissaOfDouble(Double @double) : this
	(
		new ScalarOfValue<Double>(@double)
	)
	{
	}
	
	public MantissaOfDouble(IScalar<Double> @double) : base
	(
		new SignedWithValues(
			new IsPositiveMantissa(@double),
			new NaturalOfMantissa(@double))
	)
	{
	}
}