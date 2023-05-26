using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromEnumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Exponent;

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