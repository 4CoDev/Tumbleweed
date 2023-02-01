using TumbleSystem.Numerics.Bits.FromSystem.FromSingles;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Decimal.FromSystem;

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