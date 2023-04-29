using DotGod.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.Meshes;

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