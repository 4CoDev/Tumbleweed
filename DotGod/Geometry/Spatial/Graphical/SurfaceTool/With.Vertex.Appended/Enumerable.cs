using DotGod.Geometry.Spatial.Graphical.SurfaceTool.From.Enumerable;
using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.SurfaceTool.With.Vertex.
	Appended;

public sealed class Enumerable : Envelope<Godot.SurfaceTool>
{
	public Enumerable
	(
		IEnumerable<Any> vertices,
		Any<Godot.SurfaceTool> origin
	) : base
	(
		new Aggregated<Any>(
			vertices,
			origin,
			Expression)
	)
	{
	}

	private static Any<Godot.SurfaceTool> Expression
	(
		Any<Godot.SurfaceTool> current,
		Any vertex
	) =>
	(
		new One(current, vertex)
	);
}