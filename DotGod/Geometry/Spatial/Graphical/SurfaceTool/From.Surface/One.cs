using DotGod.Geometry.Spatial.Graphical.SurfaceTool.From.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Actual = DotGod.Geometry.Spatial.Graphical.Surface.Material.Actual;
using Any = DotGod.Geometry.Spatial.Graphical.Surface.Any;

namespace DotGod.Geometry.Spatial.Graphical.SurfaceTool.From.Surface;

public sealed class One : Envelope<Godot.SurfaceTool>
{
	public One(Any surface) : base
	(
		new Aggregated<Polygon.Any>(
			new Graphical.Surface.Polygon.Enumerable.Actual(surface),
			new Initial(
				new Actual(surface)),
			Expression)
	)
	{
	}

	private static Any<Godot.SurfaceTool> Expression
	(
		Any<Godot.SurfaceTool> current,
		Polygon.Any polygon
	) =>
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Godot.SurfaceTool>(
			new With.Polygon.Appended.One(polygon, current))
	);
}