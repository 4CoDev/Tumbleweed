using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities.Meshes;

public sealed class MeshFromEntities : EnumerableEnvelope<ISurface>
{
	public MeshFromEntities
	(
		IEnumerable<IBakingEntity> entities
	) : base
	(
		new EnumerableWithElements<ISurface>(
			new SelectedByExpression<IBakingEntity, IEnumerable<ISurface>>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}