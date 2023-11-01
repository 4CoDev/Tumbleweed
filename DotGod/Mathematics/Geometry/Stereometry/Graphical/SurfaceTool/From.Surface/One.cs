using DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.From.Enumerable;
using Tumbleweed.Property.Output;
using Actual = DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Material.Actual;
using Any = DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Any;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.From.Surface;

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
		new Tumbleweed.Property.Output.Lazy<Godot.SurfaceTool>(
			new With.Polygon.Appended.One(polygon, current))
	);
}