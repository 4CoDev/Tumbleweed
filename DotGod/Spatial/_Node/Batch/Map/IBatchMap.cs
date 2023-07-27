using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Map;

public interface IBatchMap
{
	Any Batch { get; }
	
	Any<Tumbleweed.Number.Real.Any> Size { get; }
}