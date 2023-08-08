using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Node.Spatial.Batch.Entities.Meshes;

public sealed class MeshFromEntities : Geometry.Spatial.Concave.Graphical.Mesh.Envelope
{
	public MeshFromEntities
	(
		IEnumerable<ISpatialEntity> entities
	) : base
	(
		new Merged(
			new Selected<ISpatialEntity, Geometry.Spatial.Concave.Graphical.Mesh.Any>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}