using DotGod.Geometry.Spatial.Graphical.Vertices;

namespace DotGod.Geometry.Spatial.Graphical.Polygons;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}