using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.Vertex.Count;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Index.
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