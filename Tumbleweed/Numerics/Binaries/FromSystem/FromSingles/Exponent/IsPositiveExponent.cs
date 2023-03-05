using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class IsPositiveExponent : BitEnvelope
{
	public IsPositiveExponent(Single single) : this
	(
		new ScalarOfValue<Single>(single)
	)
	{
	}
	
	public IsPositiveExponent(IScalar<Single> single) : base
	(
		new BitAtIndex(
			new BitsOfSingle(single),
			30)
	)
	{
	}
}