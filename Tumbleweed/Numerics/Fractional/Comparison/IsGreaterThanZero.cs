using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class IsGreaterThanZero : BooleanEnvelope
{
	public IsGreaterThanZero
	(
		IFractional greater
	) : base
	(
		new IsGreaterThanFractional(
			greater,
			new FractionalFromSingle(0))
	)
	{
	}
}