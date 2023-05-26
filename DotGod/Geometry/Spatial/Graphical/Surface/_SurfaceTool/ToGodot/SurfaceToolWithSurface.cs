using DotGod.Geometry.Spatial.Graphical._Material;
using DotGod.Geometry.Spatial.Graphical.Polygon;
using DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot.FromEnumerable;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.ToGodot;

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