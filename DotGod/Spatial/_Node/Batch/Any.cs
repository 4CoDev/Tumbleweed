using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch;

public interface Any
{
	Tumbleweed.Array.Any<Tumbleweed.Nullable.Any<Any>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}