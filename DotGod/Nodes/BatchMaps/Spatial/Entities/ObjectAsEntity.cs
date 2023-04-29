using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

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