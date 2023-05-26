using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromEnumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Exponent;

public sealed class IsPositiveExponent : BooleanEnvelope
{
	public IsPositiveExponent(IScalar<Double> @double) : base
	(
		new BooleanAtIndex(
			new BitsOfDouble(@double),
			62)
	)
	{
	}
}