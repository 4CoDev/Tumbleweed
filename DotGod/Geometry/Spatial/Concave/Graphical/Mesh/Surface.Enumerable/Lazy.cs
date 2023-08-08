using DotGod.Geometry.Spatial.Concave.Graphical.Surface.Lazy;
using Tumbleweed.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Surface.Enumerable;

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