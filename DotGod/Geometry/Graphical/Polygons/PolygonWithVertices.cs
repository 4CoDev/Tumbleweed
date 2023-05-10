using DotGod.Geometry.Graphical.Vertices;

namespace DotGod.Geometry.Graphical.Polygons;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}