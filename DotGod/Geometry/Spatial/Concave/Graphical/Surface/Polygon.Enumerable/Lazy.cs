using DotGod.Geometry.Spatial.Concave.Graphical.Polygon;
using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Lazy;
using Tumbleweed.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface.Polygon.Enumerable;

public sealed class Lazy : Envelope<Graphical.Polygon.Any>
{
	public Lazy(Any surface) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<Graphical.Polygon.Any>(
			new Actual(surface),
			polygon => new One(polygon))
	)
	{
	}
}