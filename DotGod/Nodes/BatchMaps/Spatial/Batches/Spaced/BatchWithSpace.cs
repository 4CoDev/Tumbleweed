using DotGod.Nodes.BatchMaps.Spatial.Entities;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Tumbleweed.Arrays;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

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