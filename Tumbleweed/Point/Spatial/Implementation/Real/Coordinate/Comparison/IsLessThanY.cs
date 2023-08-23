using Tumbleweed.Number.Real.Comparison.Is.Less.Than.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsLessThanY : Boolean.Envelope
{
	public IsLessThanY
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