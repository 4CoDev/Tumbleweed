using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.Meshes;

public sealed class MeshFromEntities : EnumerableEnvelope<ISurface>
{
	public MeshFromEntities
	(
		IEnumerable<ISpatialEntity> entities
	) : base
	(
		new EnumerableWithElements<ISurface>(
			new SelectedByExpression<ISpatialEntity, IEnumerable<ISurface>>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}