using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class IsPositiveExponent : BitEnvelope
{
	public IsPositiveExponent(float single) : this
	(
		new ScalarOfValue<float>(single)
	)
	{
	}
	
	public IsPositiveExponent(IScalar<float> single) : base
	(
		new BitAtIndex(
			new BitsOfSingle(single),
			30)
	)
	{
	}
}