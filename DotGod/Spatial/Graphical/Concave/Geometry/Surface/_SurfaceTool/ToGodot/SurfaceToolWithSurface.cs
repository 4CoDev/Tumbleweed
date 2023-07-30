using DotGod.Spatial.Graphical.Concave.Geometry._Material;
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot.FromEnumerable;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.ToGodot;

public sealed class SurfaceToolWithSurface : Envelope<SurfaceTool>
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

	private static Any<SurfaceTool> Expression
	(
		Any<SurfaceTool> current,
		IPolygon polygon
	) =>
	(
		new Tumbleweed.Scalar.Immutable.Lazy<SurfaceTool>(
			new SurfaceToolWithPolygon(polygon, current))
	);
}