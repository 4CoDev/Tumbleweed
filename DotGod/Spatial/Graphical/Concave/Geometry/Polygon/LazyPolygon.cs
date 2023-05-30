using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

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