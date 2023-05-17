using DotGod.Geometry.Spatial.Graphical.Vertices;

namespace DotGod.Geometry.Spatial.Graphical.Polygons;

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