using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;

namespace DotGod.Spatial._Node.Batch;

public interface Any
{
	Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}