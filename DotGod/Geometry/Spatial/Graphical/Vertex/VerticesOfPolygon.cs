using DotGod.Geometry.Spatial.Graphical.Polygon;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public sealed class VerticesOfPolygon : EnumerableEnvelope<IVertex>
{
	public VerticesOfPolygon(IPolygon polygon) : base
	(
		new EnumerableOfFunction<IVertex>(
			() => polygon.Vertices)
	)
	{
	}
}