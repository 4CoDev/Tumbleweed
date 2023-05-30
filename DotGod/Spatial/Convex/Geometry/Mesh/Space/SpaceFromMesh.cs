using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod.Spatial.Geometry.Mesh.Vertex.Space;
using Tumbleweed.Spatial.Convex.Geometry.Mesh;
using Tumbleweed.Spatial.Convex.Geometry.Vertice;

namespace DotGod.Spatial.Convex.Geometry.Mesh.Space;

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