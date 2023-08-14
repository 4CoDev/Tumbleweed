using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Map;

public interface Any
{
	Unmeasured.Any Batch { get; }
	
	Any<Tumbleweed.Number.Real.Any> Size { get; }
}