using Tumbleweed.Boolean.Comparison.All.Are;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Comparison;

public sealed class IsLessThanOrEqualsToPoint : Boolean.Envelope
{
	public IsLessThanOrEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsLessThanOrEqualsToX(first, second),
			new IsLessThanOrEqualsToY(first, second),
			new IsLessThanOrEqualsToZ(first, second))
	)
	{
	}
}