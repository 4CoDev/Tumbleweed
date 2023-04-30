using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaOfDouble : SignedEnvelope
{
	public MantissaOfDouble(Double @double) : this
	(
		new ScalarValue<Double>(@double)
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