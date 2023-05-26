using Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex;

public sealed class MeshWithVertices : IMesh
{
	public MeshWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;

	public IEnumerable<IVertex> Vertices { get; }
}