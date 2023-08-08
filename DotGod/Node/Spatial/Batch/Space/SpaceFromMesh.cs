using Enumerable = Tumbleweed.Geometry.Spatial.Convex.Mesh.Vertex.Enumerable;

namespace DotGod.Node.Spatial.Batch.Space;

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