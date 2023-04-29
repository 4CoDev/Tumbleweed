using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Exponent;

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