using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

public sealed class ObjectAsEntity : EntityEnvelope
{
	public ObjectAsEntity(Object @object) : base
	(
		new EntityOfScalar(
			new ValueAsType<ISpatialEntity>(@object))
	)
	{
	}
}