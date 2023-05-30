using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Convex.Geometry.Mesh;

public sealed class MeshWithVertices : IMesh
{
	public MeshWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;

	public IEnumerable<IVertex> Vertices { get; }
}