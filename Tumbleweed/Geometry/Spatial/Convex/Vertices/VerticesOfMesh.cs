using Tumbleweed.Enumerables;
using Tumbleweed.Geometry.Spatial.Vertices;

namespace Tumbleweed.Geometry.Spatial.Convex.Vertices;

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