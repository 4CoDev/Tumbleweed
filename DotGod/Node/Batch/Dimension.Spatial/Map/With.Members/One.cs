using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

using Real = Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.With.Members;

public sealed class One : Map::Any
{
	public One
	(
		Batch::Any batch,
		Any<Tumbleweed.Mathematics.Number.Real.Any> size
	)
	{
		Batch = batch;
		Size = size;
	}

	public Batch::Any Batch { get; }

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Size { get; }
}