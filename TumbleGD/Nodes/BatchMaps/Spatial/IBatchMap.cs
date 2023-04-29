using TumbleGD.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial;

public interface IBatchMap
{
	ISpatialBatch Batch { get; }
	
	ISpatial<IFractional> Size { get; }
}