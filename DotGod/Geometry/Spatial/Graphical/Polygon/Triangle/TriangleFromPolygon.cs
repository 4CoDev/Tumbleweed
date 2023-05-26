using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle;

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