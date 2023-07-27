using Tumbleweed.Enumerable;

using Tumbleweed.Enumerable.Nested.Item.Value.At.Index;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index;

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