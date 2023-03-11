using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
	FromGeometrics;

public sealed class SurfaceToolsWithSurfaces
	: EnumerableEnvelope<IScalar<SurfaceTool>>
{
	public SurfaceToolsWithSurfaces(IEnumerable<ISurface> surfaces) : base
	(
		new SelectedByExpression<ISurface, IScalar<SurfaceTool>>(
			surfaces,
			surface => new SurfaceToolWithSurface(surface))
	)
	{
	}
}