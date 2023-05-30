using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}