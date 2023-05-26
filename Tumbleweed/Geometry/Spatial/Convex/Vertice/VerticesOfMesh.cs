using Tumbleweed._Enumerable;
using Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex.Vertice;

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