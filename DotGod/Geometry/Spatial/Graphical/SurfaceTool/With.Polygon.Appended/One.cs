using DotGod.Geometry.Spatial.Graphical.Polygon;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Spatial.Graphical.SurfaceTool.With.Vertex.Appended.Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.SurfaceTool.With.Polygon.
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