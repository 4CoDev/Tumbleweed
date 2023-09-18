using Tumbleweed.Point.Spatial.Generic;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.With.Members;

public sealed class One : Map::Any
{
	public One
	(
		Batch::Any batch,
		Any<Real::Any> size
	)
	{
		Batch = batch;
		Size = size;
	}

	public Batch::Any Batch { get; }

	public Any<Real::Any> Size { get; }
}