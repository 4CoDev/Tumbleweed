using Godot;
using Tumbleweed.Geometrics.Graphical.Surfaces;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;
using Tumbleweed.WithGodot.SurfaceTools.FromEnumerable;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.
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