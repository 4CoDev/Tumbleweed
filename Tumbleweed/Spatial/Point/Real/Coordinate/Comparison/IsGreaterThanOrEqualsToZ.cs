using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsGreaterThanOrEqualsToZ : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}