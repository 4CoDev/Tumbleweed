using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Space;
using Tumbleweed.Array;

namespace DotGod.Spatial._Node.Spaced.Batch;

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