using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

public sealed class IsEqualsToPoint : BooleanEnvelope
{
	public IsEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsEqualsToX(first, second),
			new IsEqualsToY(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}