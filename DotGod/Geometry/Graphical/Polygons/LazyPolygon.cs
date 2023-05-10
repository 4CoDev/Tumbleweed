using DotGod.Geometry.Graphical.Vertices;

namespace DotGod.Geometry.Graphical.Polygons;

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