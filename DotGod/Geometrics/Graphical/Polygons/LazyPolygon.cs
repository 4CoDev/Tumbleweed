using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;

namespace DotGod.Geometrics.Graphical.Polygons;

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