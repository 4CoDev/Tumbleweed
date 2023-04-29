using DotGod.Geometrics.Graphical.Vertices;

namespace DotGod.Geometrics.Graphical.Polygons;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}