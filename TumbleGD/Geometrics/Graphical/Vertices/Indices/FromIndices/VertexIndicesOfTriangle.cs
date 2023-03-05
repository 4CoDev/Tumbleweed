using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromIndices;

public sealed class VertexIndicesOfTriangle
	: EnumerableEnvelope<IScalar<Int32>>
{
	public VertexIndicesOfTriangle
	(
		IEnumerable<IScalar<Int32>> indices,
		IScalar<Int32> triangle
	) : base
	(
		new EnumerableAtIndex<IScalar<Int32>>(
			new VertexIndicesOfTriangles(indices),
			triangle)
	)
	{
	}
}