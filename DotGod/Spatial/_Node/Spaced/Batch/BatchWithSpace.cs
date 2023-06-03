using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Space;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Spaced.Batch;

public sealed class BatchWithSpace : ISpacedBatch
{
	public BatchWithSpace
	(
		IBatch batch,
		ISpace space
	)
	{
		Subbatches = new SubbatchesOfBatch(batch);
		Entities = new EntitiesOfBatch(batch);
		Space = space;
	}
	
	public INullable<IArray<IBatch>> Subbatches { get; }

	public ICollection<ISpatialEntity> Entities { get; }
	
	public ISpace Space { get; }
}