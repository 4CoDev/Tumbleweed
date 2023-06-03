using Tumbleweed.Spatial.Convex.Geometry.Mesh;
using Tumbleweed.Spatial.Convex.Geometry.Vertice;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceFromMesh : SpaceEnvelope
{
	public SpaceFromMesh(IMesh mesh) : base
	(
		new SpaceFromVertices(
			new VerticesOfMesh(mesh))
	)
	{
	}
}