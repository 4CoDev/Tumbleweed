using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Baking.Spatial.Entities;

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