using Tumbleweed.Number.Real.Comparison.Is.Less.Than.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsLessThanX : Boolean.Envelope
{
	public IsLessThanX
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