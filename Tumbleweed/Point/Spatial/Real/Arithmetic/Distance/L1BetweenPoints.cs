using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Real.With.Coordinates;
using Tumbleweed.Point.Spatial.Real.With.Coordinates.Directly;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;

public sealed class L1BetweenPoints : Envelope<Any>
{
	public L1BetweenPoints
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Unique(
			new AbsoluteDifferenceOfX(first, second),
			new AbsoluteDifferenceOfY(first, second),
			new AbsoluteDifferenceOfZ(first, second))
	)
	{
	}
}