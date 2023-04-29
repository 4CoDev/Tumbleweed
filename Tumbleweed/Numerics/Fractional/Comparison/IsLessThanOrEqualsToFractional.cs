using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class IsLessThanOrEqualsToFractional : BooleanEnvelope
{
	public IsLessThanOrEqualsToFractional
	(
		IFractional first,
		IFractional second
	) : base
	(
		new IsLessThanOrEqualsToSingle(
			new SingleFromFractional(first),
			new SingleFromFractional(second))
	)
	{
	}
}