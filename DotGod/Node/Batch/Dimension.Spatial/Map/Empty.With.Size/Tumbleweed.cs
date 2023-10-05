using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

using Real = Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class Tumbleweed : Map::Envelope
{
	public Tumbleweed
	(
		Any<global::Tumbleweed.Mathematics.Number.Real.Any> size
	) : base
	(
		new Map::With.Members.One(
			new Batch::Empty.One(),
			size)
	)
	{
	}
}