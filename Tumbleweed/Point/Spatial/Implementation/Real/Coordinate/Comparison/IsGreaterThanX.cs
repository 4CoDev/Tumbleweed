using Tumbleweed.Number.Real.Comparison.Is.Greater.Than;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsGreaterThanX : Boolean.Envelope
{
	public IsGreaterThanX
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new One(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}