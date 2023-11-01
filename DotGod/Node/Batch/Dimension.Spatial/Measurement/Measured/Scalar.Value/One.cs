using Tumbleweed.Array;
using Tumbleweed.Array.Dimension.Multi;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Property.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Property.Output.Any<Any> any) =>
		this.any = any;

	public Any<Tumbleweed.Property.Nullable.Any<Unmeasured.Any>> Subbatches =>
		any.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		any.Value.Entities;

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb =>
		any.Value.Aabb;
	
	private readonly Tumbleweed.Property.Output.Any<Any> any;
}