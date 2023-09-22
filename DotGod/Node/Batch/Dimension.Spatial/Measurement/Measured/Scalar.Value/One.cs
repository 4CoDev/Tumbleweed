using Tumbleweed.Array;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> any) =>
		this.any = any;

	public Any<Tumbleweed.Scalar.Nullable.Any<Unmeasured.Any>> Subbatches =>
		any.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		any.Value.Entities;

	public Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb =>
		any.Value.Aabb;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Any> any;
}