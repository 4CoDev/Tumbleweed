using Godot;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;
using Tumbleweed.WithGodot.SurfaceTools.FromEnumerable;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.
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