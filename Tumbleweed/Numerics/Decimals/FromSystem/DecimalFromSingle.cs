using Tumbleweed.Numerics.Bits.FromSystem.FromSingles;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals.FromSystem;

public sealed class DecimalFromSingle : DecimalEnvelope
{
	public DecimalFromSingle(float single) : this
	(
		new ScalarOfValue<float>(single)
	)
	{
	}
	
	public DecimalFromSingle(IScalar<float> single) : base
	(
		new DecimalWithValues(
			new MantissaOfSingle(single),
			new ExponentOfSingle(single))
	)
	{
	}
}