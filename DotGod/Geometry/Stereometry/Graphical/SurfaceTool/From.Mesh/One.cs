using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Any = DotGod.Geometry.Stereometry.Graphical.Mesh.Any;

namespace DotGod.Geometry.Stereometry.Graphical.SurfaceTool.From.
	Mesh;

public sealed class One
	: Envelope<Godot.SurfaceTool>
{
	public One(Any mesh) : base
	(
		new Surface.Enumerable(
			new Result<Graphical.Surface.Any>(
				() => mesh.Surfaces))
	)
	{
	}
}