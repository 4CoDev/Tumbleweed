using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.Surface.Enumerable;

public sealed class Actual : Envelope<Graphical.Surface.Any>
{
	public Actual(Any mesh) : base
	(
		new Result<Graphical.Surface.Any>(
			() => mesh.Surfaces)
	)
	{
	}
}