using DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.Number.OfSystem;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.
	Index;

public sealed class GroupedIntoTriangles
	: EnumerableEnvelope<IEnumerable<Int32>>
{
	public GroupedIntoTriangles
	(
		IEnumerable<Int32> indices
	) : base
	(
		new ChunkedBySize<Int32>(
			indices,
			new TriangleVerticesCount())
	)
	{
	}
}