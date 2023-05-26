using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace DotGod._Node.BatchMap.Batch.Index;

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