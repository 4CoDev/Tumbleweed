using DotGod.Geometry.Spatial.Concave.Graphical.Polygon;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface.Polygon.Enumerable;

public sealed class Actual : Envelope<Graphical.Polygon.Any>
{
	public Actual(Any surface) : base
	(
		new Result<Graphical.Polygon.Any>(
			() => surface.Polygons)
	)
	{
	}
}