using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot.FromEnumerable;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolWithVertices : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithVertices
	(
		IEnumerable<IVertex> vertices,
		IScalar<SurfaceTool> origin
	) : base
	(
		new AggregatedByExpression<IVertex>(
			vertices,
			origin,
			Expression)
	)
	{
	}

	private static IScalar<SurfaceTool> Expression
	(
		IScalar<SurfaceTool> current,
		IVertex vertex
	) =>
	(
		new SurfaceToolWithVertex(current, vertex)
	);
}