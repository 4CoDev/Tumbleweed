using TumbleGD.Nodes.BatchMaps.Spatial.Entities;
using Tumbleweed.Arrays;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public interface ISpatialBatch
{
	INullable<IArray<ISpatialBatch>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}