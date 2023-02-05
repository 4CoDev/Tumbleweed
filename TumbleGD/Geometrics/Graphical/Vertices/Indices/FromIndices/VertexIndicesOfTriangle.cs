using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromIndices;

public sealed class VertexIndicesOfTriangle
	: EnumerableEnvelope<IScalar<int>>
{
	public VertexIndicesOfTriangle
	(
		IEnumerable<IScalar<int>> indices,
		IScalar<int> triangle
	) : base
	(
		new EnumerableAtIndex<IScalar<int>>(
			new VertexIndicesOfTriangles(indices),
			triangle)
	)
	{
	}
}