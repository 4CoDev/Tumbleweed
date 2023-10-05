using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

using Real = Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map;

public abstract class Envelope : Map::Any
{
	protected Envelope(Map::Any map) =>
		this.map = map;

	public Batch::Any Batch =>
		map.Batch;

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Size =>
		map.Size;
	
	private readonly Map::Any map;
}