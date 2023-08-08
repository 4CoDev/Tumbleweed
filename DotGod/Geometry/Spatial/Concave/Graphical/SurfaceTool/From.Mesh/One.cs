using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Geometry.Spatial.Concave.Graphical.Surface;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Any = DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Any;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.
	Mesh;

public sealed class One
	: Envelope<Godot.SurfaceTool>
{
	public One(Any mesh) : base
	(
		new DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.Surface.Enumerable(
			new Result<Graphical.Surface.Any>(
				() => mesh.Surfaces))
	)
	{
	}
}