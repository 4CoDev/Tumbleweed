using DotGod.Node.Spatial.Batch.Entities;

namespace DotGod.Node.Spatial.Batch;

public interface Any
{
	Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches { get; }
	
	ICollection<ISpatialEntity> Entities { get; }
}