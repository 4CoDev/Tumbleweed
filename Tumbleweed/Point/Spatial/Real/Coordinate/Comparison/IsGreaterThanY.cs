using Tumbleweed.Number.Real.Comparison.Is.Greater.Than;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsGreaterThanY : Boolean.Envelope
{
	public IsGreaterThanY
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