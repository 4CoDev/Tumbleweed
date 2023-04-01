using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class LazyPolygon : PolygonEnvelope
{
	public LazyPolygon(IPolygon polygon) : base
	(
		new PolygonWithVertices(
			new LazyVertices(
				new VerticesOfPolygon(polygon)))
	)
	{
	}
}