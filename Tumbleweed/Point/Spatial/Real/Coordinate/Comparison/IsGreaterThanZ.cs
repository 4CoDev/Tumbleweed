using Tumbleweed.Number.Real.Comparison.Is.Greater.Than;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsGreaterThanZ : Boolean.Envelope
{
	public IsGreaterThanZ
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new One(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}