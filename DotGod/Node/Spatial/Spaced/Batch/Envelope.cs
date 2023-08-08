using DotGod.Node.Spatial.Batch;
using DotGod.Node.Spatial.Batch.Entities;
using DotGod.Node.Spatial.Batch.Space;

namespace DotGod.Node.Spatial.Spaced.Batch;

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