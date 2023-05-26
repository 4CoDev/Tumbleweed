using DotGod._Node.BatchMap.Spatial.Entities;
using DotGod._Node.BatchMap.Spatial.Spaces;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

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