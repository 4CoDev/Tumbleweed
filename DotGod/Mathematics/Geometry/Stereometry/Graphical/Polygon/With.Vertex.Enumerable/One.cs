namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.With.Vertex.Enumerable;

public sealed class One : Any
{
	public One(IEnumerable<Graphical.Vertex.Any> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<Graphical.Vertex.Any> Vertices { get; }
}