using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Polygons.Triangles;

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