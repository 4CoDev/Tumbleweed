using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic.Distance;

public sealed class L1BetweenPoints : PointEnvelope<IReal>
{
	public L1BetweenPoints
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new PointWithCoordinates(
			new AbsoluteDifferenceOfX(first, second),
			new AbsoluteDifferenceOfY(first, second),
			new AbsoluteDifferenceOfZ(first, second))
	)
	{
	}
}