using DotGod.Geometry.Spatial.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

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