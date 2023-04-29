using DotGod.Geometrics.Graphical.Polygons;
using Tumbleweed.Enumerables;

namespace DotGod.Geometrics.Graphical.Vertices;

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