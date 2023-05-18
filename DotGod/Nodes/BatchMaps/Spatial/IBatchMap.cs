using DotGod.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial;

public interface IBatchMap
{
	IBatch Batch { get; }
	
	IPoint<IReal> Size { get; }
}