using Tumbleweed.Number.Real.Comparison.Is.Equals.To.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsEqualsToZ : Boolean.Envelope
{
	public IsEqualsToZ
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