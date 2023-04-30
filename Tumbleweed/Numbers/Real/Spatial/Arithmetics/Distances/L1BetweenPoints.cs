using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics.Distances;

public sealed class L1BetweenPoints : SpatialEnvelope<IReal>
{
	public L1BetweenPoints
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new SpatialWithCoordinates(
			new AbsoluteDifferenceOfX(first, second),
			new AbsoluteDifferenceOfY(first, second),
			new AbsoluteDifferenceOfZ(first, second))
	)
	{
	}
}