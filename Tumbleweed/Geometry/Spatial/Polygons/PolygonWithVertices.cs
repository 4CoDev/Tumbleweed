using Tumbleweed.Geometry.Spatial.Vertices;

namespace Tumbleweed.Geometry.Spatial.Polygons;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}