using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod.Geometry.Spatial.Space;
using Tumbleweed.Geometry.Spatial.Convex;
using Tumbleweed.Geometry.Spatial.Convex.Vertice;

namespace DotGod.Geometry.Spatial.Convex.Space;

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