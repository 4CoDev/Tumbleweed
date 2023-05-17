using DotGod.Geometry.Spatial.Graphical.Materials;
using DotGod.Geometry.Spatial.Graphical.Polygons;
using DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.OfGodot.FromEnumerable;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.ToGodot;

public sealed class SurfaceToolWithSurface : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithSurface(ISurface surface) : base
	(
		new AggregatedByExpression<IPolygon>(
			new PolygonsOfSurface(surface),
			new InitialSurfaceToolWithMaterial(
				new MaterialOfSurface(surface)),
			Expression)
	)
	{
	}

	private static IScalar<SurfaceTool> Expression
	(
		IScalar<SurfaceTool> current,
		IPolygon polygon
	) =>
	(
		new LazyValue<SurfaceTool>(
			new SurfaceToolWithPolygon(polygon, current))
	);
}