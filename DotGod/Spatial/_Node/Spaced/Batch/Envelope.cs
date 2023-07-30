using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Space;
using Tumbleweed.Array;

namespace DotGod.Spatial._Node.Spaced.Batch;

public abstract class Envelope : Abstract.IBatch
{
	protected Envelope(Abstract.IBatch batch) =>
		this.batch = batch;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		batch.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		batch.Entities;

	public ISpace Space =>
		batch.Space;

	private readonly Abstract.IBatch batch;
}