using Godot;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot.FromEnumerable;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
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