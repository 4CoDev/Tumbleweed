using DotGod.Geometry.Graphical.Surfaces.SurfaceTools.OfGodot.FromEnumerable;
using DotGod.Geometry.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.
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