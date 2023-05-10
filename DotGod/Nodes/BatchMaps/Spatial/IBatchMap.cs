using DotGod.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial;

public interface IBatchMap
{
	IBatch Batch { get; }
	
	ISpatial<IReal> Size { get; }
}