using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Entities;

public sealed class ObjectAsEntity : EntityEnvelope
{
	public ObjectAsEntity(Object @object) : base
	(
		new EntityOfScalar(
			new ObjectAsType<ISpatialEntity>(@object))
	)
	{
	}
}