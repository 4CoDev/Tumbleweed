using Godot;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.
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