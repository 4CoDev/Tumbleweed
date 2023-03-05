using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices;

public sealed class VertexIndicesFromSurfaceTool
	: EnumerableEnvelope<IScalar<Int32>>
{
	public VertexIndicesFromSurfaceTool(IScalar<SurfaceTool> surfaceTool) : base
	(
		new EnumerableOfScalar<IScalar<Int32>>(
			new Scalar.VertexIndicesFromSurfaceTool(surfaceTool))
	)
	{
	}
}