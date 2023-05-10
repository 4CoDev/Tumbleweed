using DotGod.Geometry.Graphical.Vertices;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Graphical.Polygons.Triangles;

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