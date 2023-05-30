using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle;

public sealed class TriangleFromPolygon : PolygonEnvelope
{
	public TriangleFromPolygon(IPolygon polygon) : base
	(
		new TriangleWithVertices(
			new EnumerableOfFunction<IVertex>(
				() => polygon.Vertices))
	)
	{
	}
}