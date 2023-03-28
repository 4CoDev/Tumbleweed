using TumbleGD.Geometrics.Graphical.Vertices;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class PolygonWithVertices : IPolygon
{
	public PolygonWithVertices(IEnumerable<IVertex> vertices) =>
		Vertices = vertices;
	
	public IEnumerable<IVertex> Vertices { get; }
}