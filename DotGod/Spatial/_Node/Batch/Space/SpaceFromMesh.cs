using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Geometry.Spatial.Convex.Mesh.Vertex;
using Enumerable = Tumbleweed.Geometry.Spatial.Convex.Mesh.Vertex.Enumerable;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceFromMesh : SpaceEnvelope
{
	public SpaceFromMesh(Tumbleweed.Geometry.Spatial.Convex.Mesh.Any mesh) : base
	(
		new SpaceFromVertices(
			new Enumerable(mesh))
	)
	{
	}
}