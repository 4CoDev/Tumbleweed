using Tumbleweed._Enumerable;
using Tumbleweed.Spatial.Convex.Geometry.Mesh;
using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Convex.Geometry.Vertice;

public sealed class VerticesOfMesh : EnumerableEnvelope<IVertex>
{
	public VerticesOfMesh(IMesh mesh) : base
	(
		new EnumerableOfFunction<IVertex>(
			() => mesh.Vertices)
	)
	{
	}
}