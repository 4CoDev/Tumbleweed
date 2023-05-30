using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Comparison;

public sealed class IsGreaterThanOrEqualsToPoint : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsGreaterThanOrEqualsToX(first, second),
			new IsGreaterThanOrEqualsToY(first, second),
			new IsGreaterThanOrEqualsToZ(first, second))
	)
	{
	}
}