using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics.Distances;

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