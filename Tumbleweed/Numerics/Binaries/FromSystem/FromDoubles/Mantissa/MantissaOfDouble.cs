using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class MantissaOfDouble : SignedEnvelope
{
	public MantissaOfDouble(double @double) : this
	(
		new ScalarOfValue<double>(@double)
	)
	{
	}
	
	public MantissaOfDouble(IScalar<double> @double) : base
	(
		new SignedWithValues(
			new IsPositiveMantissa(@double),
			new NaturalOfMantissa(@double))
	)
	{
	}
}