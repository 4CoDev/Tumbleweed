using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Space;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Spaced.Batch;

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