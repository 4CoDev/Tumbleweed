using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial._Node.Batch.Entities.Meshes;

public sealed class MeshFromEntities : MeshEnvelope
{
	public MeshFromEntities
	(
		IEnumerable<ISpatialEntity> entities
	) : base
	(
		new MergedMeshes(
			new Selected<ISpatialEntity, IMesh>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}