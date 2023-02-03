using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.SurfaceTools.FromEnumerable;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
	FromGeometrics;

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
			(result, vertex) =>
				new SurfaceToolWithVertex(result, vertex))
	)
	{
	}
}