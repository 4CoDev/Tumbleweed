using Tumbleweed.Number.Real.Comparison.Is.Equals.To.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsEqualsToY : Boolean.Envelope
{
	public IsEqualsToY
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new One(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}