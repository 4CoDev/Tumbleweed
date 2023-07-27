using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class ObjectAsEntity : EntityEnvelope
{
	public ObjectAsEntity(Object @object) : base
	(
		new EntityOfScalar(
			new Tumbleweed.Object.Unpacked<ISpatialEntity>(@object))
	)
	{
	}
}