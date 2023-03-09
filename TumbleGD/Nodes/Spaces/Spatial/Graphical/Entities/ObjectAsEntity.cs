using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;

public sealed class ObjectAsEntity : EntityEnvelope
{
	public ObjectAsEntity(Object @object) : base
	(
		new EntityOfScalar(
			new ValueAsType<IBakingEntity>(@object))
	)
	{
	}
}