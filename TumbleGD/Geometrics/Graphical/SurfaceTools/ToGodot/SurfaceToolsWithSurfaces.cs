using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
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