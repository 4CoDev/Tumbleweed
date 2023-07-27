using Godot;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolsWithSurfaces
	: Envelope<SurfaceTool>
{
	public SurfaceToolsWithSurfaces(IEnumerable<ISurface> surfaces) : base
	(
		new Selected<ISurface, SurfaceTool>(
			surfaces,
			surface => new SurfaceToolWithSurface(surface).Value)
	)
	{
	}
}