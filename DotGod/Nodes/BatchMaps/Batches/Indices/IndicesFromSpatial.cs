using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndicesFromPoint : PointEnvelope<INatural>
{
	public IndicesFromPoint(IPoint<IReal> point) : base
	(
		new PointWithCoordinates<INatural>(
			new IndexFromFractional(new XOfSpatial(point)),
			new IndexFromFractional(new YOfSpatial(point)),
			new IndexFromFractional(new ZOfSpatial(point)))
	)
	{
	}
}