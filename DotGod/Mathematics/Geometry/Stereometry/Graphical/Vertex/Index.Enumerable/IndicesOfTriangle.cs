using Tumbleweed.Enumerable.Nested.Item.Value.At.Index;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Index.Enumerable;

public sealed class IndicesOfTriangle
	: Tumbleweed.Enumerable.Envelope<Int32>
{
	public IndicesOfTriangle
	(
		IEnumerable<Int32> indices,
		Any<Int32> triangle
	) : base
	(
		new System<Int32>(
			new GroupedIntoTriangles(indices),
			triangle)
	)
	{
	}
}