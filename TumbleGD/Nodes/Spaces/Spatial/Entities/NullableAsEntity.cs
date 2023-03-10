using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

public sealed class NullableAsEntity : ScalarEnvelope<ISpatialEntity?>
{
	public NullableAsEntity(Object? @object) : base
	(
		new NullableAsType<ISpatialEntity>(@object)
	)
	{
	}
}