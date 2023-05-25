using DotGod.Geometry.Spatial.Spaces;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Tumbleweed.Geometry.Spatial.Convex;
using Tumbleweed.Geometry.Spatial.Convex.Vertices;

namespace DotGod.Geometry.Spatial.Convex.Spaces;

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