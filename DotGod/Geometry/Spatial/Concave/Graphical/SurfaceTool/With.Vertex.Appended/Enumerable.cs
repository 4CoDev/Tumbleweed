using DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.With.Vertex.
	Appended;

public sealed class Enumerable : Envelope<Godot.SurfaceTool>
{
	public Enumerable
	(
		IEnumerable<Graphical.Vertex.Any> vertices,
		Any<Godot.SurfaceTool> origin
	) : base
	(
		new Aggregated<Graphical.Vertex.Any>(
			vertices,
			origin,
			Expression)
	)
	{
	}

	private static Any<Godot.SurfaceTool> Expression
	(
		Any<Godot.SurfaceTool> current,
		Graphical.Vertex.Any vertex
	) =>
	(
		new One(current, vertex)
	);
}