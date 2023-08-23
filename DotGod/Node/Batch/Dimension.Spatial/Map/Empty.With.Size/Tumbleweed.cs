using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class Tumbleweed : Map::Envelope
{
	public Tumbleweed(Point::Any<Real::Any> size) : base
	(
		new Map::With.Members.One(
			new Batch::Empty.One(),
			size)
	)
	{
	}
}