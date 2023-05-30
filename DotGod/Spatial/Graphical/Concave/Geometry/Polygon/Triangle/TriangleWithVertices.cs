using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed._Enumerable.FromSystem;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle;

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