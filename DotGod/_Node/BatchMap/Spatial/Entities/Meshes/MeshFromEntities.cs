using DotGod.Geometry.Spatial.Graphical._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod._Node.BatchMap.Spatial.Entities.Meshes;

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