using Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;
using Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalFromSingle : FractionalEnvelope
{
	public FractionalFromSingle(Single single) : this
	(
		new ScalarOfValue<Single>(single)
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