using DotGod._Node.BatchMap.Spatial.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Batches;

public interface IBatch
{
	INullable<IArray<IBatch>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}