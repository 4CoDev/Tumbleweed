using Tumbleweed.Array.Dimension.Multi;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

public abstract class Envelope : Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public Any<Tumbleweed.Scalar.Nullable.Any<Unmeasured.Any>> Subbatches =>
		batch.Subbatches;

	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb =>
		batch.Aabb;

	private readonly Any batch;
}