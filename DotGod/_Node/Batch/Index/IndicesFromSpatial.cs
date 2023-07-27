using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;
using Any = Tumbleweed.Number.Real.Any;

namespace DotGod._Node.Batch.Index;

public sealed class IndicesFromPoint : Envelope<Tumbleweed.Number.Natural.Any>
{
	public IndicesFromPoint(Any<Any> point) : base
	(
		new Unique<Tumbleweed.Number.Natural.Any>(
			new IndexFromFractional(new XOfPoint(point)),
			new IndexFromFractional(new YOfPoint(point)),
			new IndexFromFractional(new ZOfPoint(point)))
	)
	{
	}
}