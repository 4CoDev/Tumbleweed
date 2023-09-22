using DotGod.Geometry.Stereometry.Graphical.Polygon.Lazy;
using Tumbleweed.Enumerable;

namespace DotGod.Geometry.Stereometry.Graphical.Surface.Polygon.Enumerable;

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