using Tumbleweed.Number.Real.Comparison.Is.Equals.To.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsEqualsToX : Boolean.Envelope
{
	public IsEqualsToX
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