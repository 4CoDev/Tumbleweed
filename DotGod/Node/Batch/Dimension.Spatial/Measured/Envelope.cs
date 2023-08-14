namespace DotGod.Node.Batch.Dimension.Spatial.Measured;

public abstract class Envelope : Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Unmeasured.Any>> Subbatches =>
		batch.Subbatches;

	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	public Tumbleweed.Geometry.Spatial.Aabb.Any Aabb =>
		batch.Aabb;

	private readonly Any batch;
}