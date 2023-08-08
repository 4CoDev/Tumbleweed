using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Surface.Enumerable;

public sealed class Actual : Envelope<Surface::Any>
{
	public Actual(Any mesh) : base
	(
		new Result<Surface::Any>(
			() => mesh.Surfaces)
	)
	{
	}
}