using DotGod.Nodes.BatchMaps.Spatial.Entities;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Tumbleweed.Arrays;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

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