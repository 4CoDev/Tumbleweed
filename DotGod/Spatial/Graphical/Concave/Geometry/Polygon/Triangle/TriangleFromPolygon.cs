using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle;

public sealed class TriangleFromPolygon : PolygonEnvelope
{
	public TriangleFromPolygon(IPolygon polygon) : base
	(
		new TriangleWithVertices(
			new Result<IVertex>(
				() => polygon.Vertices))
	)
	{
	}
}