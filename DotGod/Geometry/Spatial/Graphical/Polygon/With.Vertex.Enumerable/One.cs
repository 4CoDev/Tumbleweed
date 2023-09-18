namespace DotGod.Geometry.Spatial.Graphical.Polygon.With.Vertex.Enumerable;

public sealed class One : Any
{
	public One(IEnumerable<Graphical.Vertex.Any> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<Graphical.Vertex.Any> Vertices { get; }
}