using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member.Batch;

public sealed class Unmeasured : Measurement.Unmeasured.Envelope
{
	public Unmeasured(Map::Any map) : base
	(
		new Batch::Function.Result.One(
			() => map.Batch)
	)
	{
	}
}