using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed._Enumerable.FromSystem;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle;

public sealed class TriangleWithVertices : PolygonEnvelope
{
	public TriangleWithVertices(IEnumerable<IVertex> vertices) : base
	(
		new PolygonWithVertices(
			new EnumerableWithSize<IVertex>(vertices, 3))
	)
	{
	}
}