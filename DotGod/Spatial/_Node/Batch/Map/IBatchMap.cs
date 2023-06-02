using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Map;

public interface IBatchMap
{
	IBatch Batch { get; }
	
	IPoint<IReal> Size { get; }
}