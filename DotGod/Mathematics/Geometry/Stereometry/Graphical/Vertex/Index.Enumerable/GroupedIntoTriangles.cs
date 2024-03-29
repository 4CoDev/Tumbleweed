using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Index.
	Enumerable;

public sealed class GroupedIntoTriangles
	: Envelope<IEnumerable<Int32>>
{
	public GroupedIntoTriangles
	(
		IEnumerable<Int32> indices
	) : base
	(
		new System<Int32>(
			indices,
			new Polygon.Triangle.Vertex.Count.System())
	)
	{
	}
}