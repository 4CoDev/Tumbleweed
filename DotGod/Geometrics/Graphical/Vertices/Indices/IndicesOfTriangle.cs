using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Vertices.Indices;

public sealed class IndicesOfTriangle
	: EnumerableEnvelope<Int32>
{
	public IndicesOfTriangle
	(
		IEnumerable<Int32> indices,
		IScalar<Int32> triangle
	) : base
	(
		new EnumerableAtIndex<Int32>(
			new GroupedIntoTriangles(indices),
			triangle)
	)
	{
	}
}