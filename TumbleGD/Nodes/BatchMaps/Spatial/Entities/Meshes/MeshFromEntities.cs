using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities.Meshes;

public sealed class MeshFromEntities : MeshEnvelope
{
	public MeshFromEntities
	(
		IEnumerable<ISpatialEntity> entities
	) : base
	(
		new MergedMeshes(
			new SelectedByExpression<ISpatialEntity, IMesh>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}