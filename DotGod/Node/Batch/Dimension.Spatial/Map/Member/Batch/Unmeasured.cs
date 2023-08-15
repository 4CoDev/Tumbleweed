using DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Function.Result;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member.Batch;

public sealed class Unmeasured : Envelope
{
	public Unmeasured(Map::Any map) : base
	(
		new One(
			() => map.Batch)
	)
	{
	}
}