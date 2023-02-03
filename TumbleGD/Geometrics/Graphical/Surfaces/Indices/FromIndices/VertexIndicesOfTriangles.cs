using TumbleGD.Geometrics.Graphical.Numbers;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.Indices.
	FromIndices;

public sealed class VertexIndicesOfTriangles
	: EnumerableEnvelope<IEnumerable<IScalar<int>>>
{
	public VertexIndicesOfTriangles
	(
		IEnumerable<IScalar<int>> indices
	) : base
	(
		new ChunkedBySize<IScalar<int>>(indices, new TriangleVerticesCount())
	)
	{
	}
}