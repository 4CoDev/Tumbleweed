using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.Indices;

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