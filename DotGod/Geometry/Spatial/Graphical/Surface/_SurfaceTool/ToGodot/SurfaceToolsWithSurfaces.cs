using Godot;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolsWithSurfaces
	: EnumerableEnvelope<SurfaceTool>
{
	public SurfaceToolsWithSurfaces(IEnumerable<ISurface> surfaces) : base
	(
		new SelectedByExpression<ISurface, SurfaceTool>(
			surfaces,
			surface => new SurfaceToolWithSurface(surface).Value)
	)
	{
	}
}