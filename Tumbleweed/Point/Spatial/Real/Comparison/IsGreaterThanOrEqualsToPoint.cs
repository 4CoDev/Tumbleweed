using Tumbleweed.Boolean.Comparison.All.Are;
using Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

public sealed class IsGreaterThanOrEqualsToPoint : Boolean.Envelope
{
	public IsGreaterThanOrEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsGreaterThanOrEqualsToX(first, second),
			new IsGreaterThanOrEqualsToY(first, second),
			new IsGreaterThanOrEqualsToZ(first, second))
	)
	{
	}
}