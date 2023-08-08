using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.With.Vertex.Enumerable;

public sealed class One : Any
{
	public One(IEnumerable<Vertex::Any> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<Vertex::Any> Vertices { get; }
}