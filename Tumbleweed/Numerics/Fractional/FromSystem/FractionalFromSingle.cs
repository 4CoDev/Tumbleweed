using Tumbleweed.Numerics.Bits.FromSystem.FromSingles;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalFromSingle : FractionalEnvelope
{
	public FractionalFromSingle(float single) : this
	(
		new ScalarOfValue<float>(single)
	)
	{
	}

	public FractionalFromSingle(IScalar<float> single) : base
	(
		new FractionalWithValues(
			new MantissaOfSingle(single),
			new BaseOfSingle(),
			new ExponentOfSingle(single))
	)
	{
	}
}