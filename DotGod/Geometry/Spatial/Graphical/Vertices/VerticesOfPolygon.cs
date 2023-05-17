using DotGod.Geometry.Spatial.Graphical.Polygons;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

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