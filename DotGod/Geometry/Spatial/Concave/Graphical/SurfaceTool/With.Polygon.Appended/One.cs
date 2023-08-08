using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.With.Vertex.Appended.Enumerable;
using One = DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Vertex.Enumerable.One;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.With.Polygon.
	Appended;

public sealed class One : Envelope<Godot.SurfaceTool>
{
	public One
	(
		Graphical.Polygon.Any polygon,
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