using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndicesFromPoint : PointEnvelope<INatural>
{
	public IndicesFromPoint(IPoint<IReal> point) : base
	(
		new PointWithCoordinates<INatural>(
			new IndexFromFractional(new XOfPoint(point)),
			new IndexFromFractional(new YOfPoint(point)),
			new IndexFromFractional(new ZOfPoint(point)))
	)
	{
	}
}