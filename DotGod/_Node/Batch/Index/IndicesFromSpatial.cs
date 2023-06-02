using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace DotGod._Node.Batch.Index;

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