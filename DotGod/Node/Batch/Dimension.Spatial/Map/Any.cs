using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Map;

public interface Any
{
	Measurement.Unmeasured.Any Batch { get; }
	
	Any<Tumbleweed.Mathematics.Number.Real.Any> Size { get; }
}