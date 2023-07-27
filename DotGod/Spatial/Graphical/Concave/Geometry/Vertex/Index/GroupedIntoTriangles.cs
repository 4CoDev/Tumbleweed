using DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.Number.OfSystem;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;


namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.
	Index;

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
			new TriangleVerticesCount())
	)
	{
	}
}