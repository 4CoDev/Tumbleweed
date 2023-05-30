using DotGod._Node.BatchMap.Spatial.Batches;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod._Node.BatchMap.Spatial;

public interface IBatchMap
{
	IBatch Batch { get; }
	
	IPoint<IReal> Size { get; }
}