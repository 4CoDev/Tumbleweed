using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Comparison;

public sealed class IsLessThanOrEqualsToPoint : BooleanEnvelope
{
	public IsLessThanOrEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsLessThanOrEqualsToX(first, second),
			new IsLessThanOrEqualsToY(first, second),
			new IsLessThanOrEqualsToZ(first, second))
	)
	{
	}
}