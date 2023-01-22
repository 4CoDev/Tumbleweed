using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.Indices;

public sealed class VertexIndicesFromSurfaceTool
	: EnumerableEnvelope<IScalar<int>>
{
	public VertexIndicesFromSurfaceTool(IScalar<SurfaceTool> surfaceTool) : base
	(
		new EnumerableOfScalar<IScalar<int>>(
			new Scalar.VertexIndicesFromSurfaceTool(surfaceTool))
	)
	{
	}
}