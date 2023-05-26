using Tumbleweed.Number.Integer.Signed.FromSystem;
using Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Exponent;
using Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Mantissa;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.FromSystem;

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