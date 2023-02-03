using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.SurfaceTools.FromEnumerable;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
	FromGeometrics;

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