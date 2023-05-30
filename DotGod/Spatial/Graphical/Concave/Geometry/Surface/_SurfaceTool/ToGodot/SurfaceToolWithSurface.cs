using DotGod.Spatial.Graphical.Concave.Geometry._Material;
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot.FromEnumerable;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.ToGodot;

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