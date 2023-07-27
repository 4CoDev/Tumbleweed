using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot.FromEnumerable;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolWithVertices : Envelope<SurfaceTool>
{
	public SurfaceToolWithVertices
	(
		IEnumerable<IVertex> vertices,
		Any<SurfaceTool> origin
	) : base
	(
		new AggregatedByExpression<IVertex>(
			vertices,
			origin,
			Expression)
	)
	{
	}

	private static Any<SurfaceTool> Expression
	(
		Any<SurfaceTool> current,
		IVertex vertex
	) =>
	(
		new SurfaceToolWithVertex(current, vertex)
	);
}