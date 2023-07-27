using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VerticesOfPolygon : Envelope<IVertex>
{
	public VerticesOfPolygon(IPolygon polygon) : base
	(
		new Result<IVertex>(
			() => polygon.Vertices)
	)
	{
	}
}