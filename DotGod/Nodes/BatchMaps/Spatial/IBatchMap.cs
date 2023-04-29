using DotGod.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial;

public interface IBatchMap
{
	ISpatialBatch Batch { get; }
	
	ISpatial<IFractional> Size { get; }
}