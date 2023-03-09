using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;

public sealed class NullableAsEntity : ScalarEnvelope<IBakingEntity?>
{
	public NullableAsEntity(Object? @object) : base
	(
		new NullableAsType<IBakingEntity>(@object)
	)
	{
	}
}