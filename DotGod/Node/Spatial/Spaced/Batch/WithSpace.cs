using DotGod.Node.Spatial.Batch;
using DotGod.Node.Spatial.Batch.Entities;
using DotGod.Node.Spatial.Batch.Space;

namespace DotGod.Node.Spatial.Spaced.Batch;

public sealed class WithSpace : Spaced.Abstract.IBatch
{
	public WithSpace
	(
		Any batch,
		ISpace space
	)
	{
		Subbatches = new Nullable.Subbatch.Array.Of.Batch(batch);
		Entities = new EntitiesOfBatch(batch);
		Space = space;
	}
	
	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches { get; }

	public ICollection<ISpatialEntity> Entities { get; }
	
	public ISpace Space { get; }
}