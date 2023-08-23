using Tumbleweed.Number.Real.Comparison.Is.Less.Than.Other;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsLessThanZ : Boolean.Envelope
{
	public IsLessThanZ
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