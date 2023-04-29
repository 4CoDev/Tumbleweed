using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class IsGreaterThanOrEqualsToFractional : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToFractional
	(
		IFractional first,
		IFractional second
	) : base
	(
		new IsGreaterThanOrEqualsToSingle(
			new SingleFromFractional(first),
			new SingleFromFractional(second))
	)
	{
	}
}