using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot.FromEnumerable;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.ToGodot;

public sealed class SurfaceToolWithSurface : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithSurface(ISurface surface) : base
	(
		new AggregatedByExpression<IEnumerable<IVertex>>(
			surface.Polygons,
			new InitialSurfaceToolWithMaterial(surface.Material),
			(result, vertices) =>
				new SurfaceToolWithVertices(vertices, result))
	)
	{
	}
}