using Godot;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member.Batch;

public sealed class Measured : Batch::Measured.Envelope
{
	public Measured(Map::Any map) : base
	(
		new Batch::Unmeasured.Measured.With.Size.At.Center.One(
			new Map::Member.Batch.Unmeasured(map),
			new Map::Member.Size(map))
	)
	{
	}
}