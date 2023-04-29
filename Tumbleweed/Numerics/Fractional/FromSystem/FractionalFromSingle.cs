using Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles.Exponent;
using Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles.Mantissa;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalFromSingle : FractionalEnvelope
{
	public FractionalFromSingle(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}

	public FractionalFromSingle(IScalar<Single> single) : base
	(
		new FractionalWithValues(
			new MantissaOfSingle(single),
			new BaseOfSingle(),
			new ExponentOfSingle(single))
	)
	{
	}
}