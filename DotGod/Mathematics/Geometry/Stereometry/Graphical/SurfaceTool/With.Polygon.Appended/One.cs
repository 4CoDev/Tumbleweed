using DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.With.Vertex.Appended.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.With.Polygon.
	Appended;

public sealed class One : Envelope<Godot.SurfaceTool>
{
	public One
	(
		Any polygon,
		Any<Godot.SurfaceTool> tool
	) : base
	(
		new Enumerable(
			new Graphical.Polygon.Vertex.Enumerable.One(polygon),
			tool)
	)
	{
	}
}