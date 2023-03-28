using TumbleGD.Geometrics.Graphical.Polygons;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Vertices;

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