using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Map;

public interface Any
{
	Measurement.Unmeasured.Any Batch { get; }
	
	Any<Tumbleweed.Number.Real.Any> Size { get; }
}