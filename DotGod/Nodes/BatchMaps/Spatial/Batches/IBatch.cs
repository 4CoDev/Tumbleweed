using DotGod.Nodes.BatchMaps.Spatial.Entities;
using Tumbleweed.Arrays;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public interface IBatch
{
	INullable<IArray<IBatch>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}