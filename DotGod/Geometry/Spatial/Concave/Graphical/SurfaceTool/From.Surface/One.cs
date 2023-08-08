using DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Actual = DotGod.Geometry.Spatial.Concave.Graphical.Surface.Material.Actual;
using Any = DotGod.Geometry.Spatial.Concave.Graphical.Surface.Any;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.Surface;

public sealed class One : Envelope<Godot.SurfaceTool>
{
	public One(Any surface) : base
	(
		new Aggregated<Graphical.Polygon.Any>(
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
		Graphical.Polygon.Any polygon
	) =>
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Godot.SurfaceTool>(
			new With.Polygon.Appended.One(polygon, current))
	);
}