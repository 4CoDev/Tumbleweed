namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

public abstract class Envelope : Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Unmeasured.Any>> Subbatches =>
		batch.Subbatches;

	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	public Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any Aabb =>
		batch.Aabb;

	private readonly Any batch;
}