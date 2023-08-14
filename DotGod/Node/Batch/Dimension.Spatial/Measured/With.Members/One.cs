using Tumbleweed.Scalar.Nullable;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.With.Members;

public sealed class One : Any
{
	public One
	(
		Tumbleweed.Array.Any<Any<Unmeasured.Any>> subbatches,
		ICollection<Entity.Any> entities,
		Tumbleweed.Geometry.Spatial.Aabb.Any space
	)
	{
		Subbatches = subbatches;
		Entities = entities;
		Aabb = space;
	}
	
	public Tumbleweed.Array.Any<Any<Unmeasured.Any>> Subbatches { get; }

	public ICollection<Entity.Any> Entities { get; }

	public Tumbleweed.Geometry.Spatial.Aabb.Any Aabb { get; }
}