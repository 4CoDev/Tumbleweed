using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Concave.Geometry.Polygon;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}