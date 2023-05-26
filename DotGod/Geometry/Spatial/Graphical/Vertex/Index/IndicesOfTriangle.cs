using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.Index;

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