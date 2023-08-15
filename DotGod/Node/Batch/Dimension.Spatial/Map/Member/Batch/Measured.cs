using DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Measured.With.Size.At.Center;
using Batch = DotGod.Node.Batch.Dimension.Spatial;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member.Batch;

public sealed class Measured : Envelope
{
	public Measured(Map::Any map) : base
	(
		new One(
			new Map::Member.Batch.Unmeasured(map),
			new Map::Member.Size(map))
	)
	{
	}
}