using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class IsEqualsToFractional : BooleanEnvelope
{
	public IsEqualsToFractional
	(
		IFractional first,
		IFractional second
	) : base
	(
		new IsEqualsToSingle(
			new SingleFromFractional(first),
			new SingleFromFractional(second))
	)
	{
	}
}