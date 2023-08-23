using Tumbleweed.Boolean.Comparison.All.Are;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Comparison;

public sealed class IsEqualsToPoint : Boolean.Envelope
{
	public IsEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsEqualsToX(first, second),
			new IsEqualsToY(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}