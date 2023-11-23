using Tumbleweed.Property.Option;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.With.Members;

public sealed class One : Any
{
	public One
	(Tumbleweed.Array.Dimension.Multi.Any<Any<Unmeasured.Any>> subbatches,
		ICollection<Entity.Any> entities,
		Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any space
	)
	{
		Subbatches = subbatches;
		Entities = entities;
		Aabb = space;
	}
	
	public Tumbleweed.Array.Dimension.Multi.Any<Any<Unmeasured.Any>> Subbatches { get; }

	public ICollection<Entity.Any> Entities { get; }

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb { get; }
}