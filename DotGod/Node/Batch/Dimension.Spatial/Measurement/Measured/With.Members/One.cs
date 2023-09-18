using Tumbleweed.Scalar.Nullable;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.With.Members;

public sealed class One : Any
{
	public One
	(
		Tumbleweed.Array.Any<Any<Unmeasured.Any>> subbatches,
		ICollection<Entity.Any> entities,
		Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any space
	)
	{
		Subbatches = subbatches;
		Entities = entities;
		Aabb = space;
	}
	
	public Tumbleweed.Array.Any<Any<Unmeasured.Any>> Subbatches { get; }

	public ICollection<Entity.Any> Entities { get; }

	public Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any Aabb { get; }
}