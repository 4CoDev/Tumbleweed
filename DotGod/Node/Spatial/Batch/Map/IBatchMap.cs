using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Map;

public interface IBatchMap
{
	Any Batch { get; }
	
	Any<Tumbleweed.Number.Real.Any> Size { get; }
}