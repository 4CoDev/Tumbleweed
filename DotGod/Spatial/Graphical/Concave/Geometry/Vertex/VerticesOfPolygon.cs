using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

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