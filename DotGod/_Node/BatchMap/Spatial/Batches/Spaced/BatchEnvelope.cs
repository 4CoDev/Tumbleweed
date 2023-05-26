using DotGod._Node.BatchMap.Spatial.Entities;
using DotGod._Node.BatchMap.Spatial.Spaces;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

public abstract class BatchEnvelope : ISpacedBatch
{
	protected BatchEnvelope(ISpacedBatch batch) =>
		this.batch = batch;

	public INullable<IArray<IBatch>> Subbatches =>
		batch.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		batch.Entities;

	public ISpace Space =>
		batch.Space;

	private readonly ISpacedBatch batch;
}