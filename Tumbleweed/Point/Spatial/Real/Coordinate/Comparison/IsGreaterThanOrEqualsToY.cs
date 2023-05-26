using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsGreaterThanOrEqualsToY : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}