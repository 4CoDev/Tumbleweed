using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Numbers;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.Indices.
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