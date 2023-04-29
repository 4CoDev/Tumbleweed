using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles.Exponent;

public sealed class IsPositiveExponent : BooleanEnvelope
{
	public IsPositiveExponent(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}
	
	public IsPositiveExponent(IScalar<Single> single) : base
	(
		new BooleanAtIndex(
			new BitsOfSingle(single),
			30)
	)
	{
	}
}