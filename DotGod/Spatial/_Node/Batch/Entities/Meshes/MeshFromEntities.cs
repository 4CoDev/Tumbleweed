using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial._Node.Batch.Entities.Meshes;

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