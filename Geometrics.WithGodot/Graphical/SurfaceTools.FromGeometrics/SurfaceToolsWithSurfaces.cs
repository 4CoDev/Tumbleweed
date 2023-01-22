using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.
	FromGeometrics;

public sealed class SurfaceToolsWithSurfaces
	: EnumerableEnvelope<IScalar<SurfaceTool>>
{
	public SurfaceToolsWithSurfaces(IEnumerable<ISurface> surfaces) : base
	(
		new SelectedByExpression<ISurface, IScalar<SurfaceTool>>
		(
			surfaces,
			surface => new SurfaceToolWithSurface(surface)
		)
	)
	{
	}
}