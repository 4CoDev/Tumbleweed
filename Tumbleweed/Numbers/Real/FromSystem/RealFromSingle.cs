using Tumbleweed.Numbers.Integers.Signed.FromSystem;
using Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Exponent;
using Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Mantissa;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.FromSystem;

public sealed class RealFromSingle : RealEnvelope
{
	public RealFromSingle(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}

	public RealFromSingle(IScalar<Single> single) : base
	(
		new RealWithValues(
			new MantissaOfSingle(single),
			new BaseOfSingle(),
			new ExponentOfSingle(single))
	)
	{
	}
}