using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Baking.Spatial.Entities;

public sealed class NullableAsEntity : ScalarEnvelope<IBakingEntity?>
{
	public NullableAsEntity(Object? @object) : base
	(
		new NullableAsType<IBakingEntity>(@object)
	)
	{
	}
}