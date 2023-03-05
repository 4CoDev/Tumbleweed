using TumbleGD.Geometrics.Graphical.Numbers;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.
	FromIndices;

public sealed class VertexIndicesOfTriangles
	: EnumerableEnvelope<IEnumerable<IScalar<Int32>>>
{
	public VertexIndicesOfTriangles
	(
		IEnumerable<IScalar<Int32>> indices
	) : base
	(
		new ChunkedBySize<IScalar<Int32>>(indices, new TriangleVerticesCount())
	)
	{
	}
}