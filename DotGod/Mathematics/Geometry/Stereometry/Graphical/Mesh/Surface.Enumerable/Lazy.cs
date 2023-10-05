using DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Lazy;
using Tumbleweed.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.Surface.Enumerable;

public sealed class Lazy : Envelope<Graphical.Surface.Any>
{
	public Lazy(Any mesh) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<Graphical.Surface.Any>(
			new Actual(mesh),
			surface => new One(surface))
	)
	{
	}
}