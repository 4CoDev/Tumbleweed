using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch;

public interface IBatch
{
	INullable<IArray<IBatch>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}