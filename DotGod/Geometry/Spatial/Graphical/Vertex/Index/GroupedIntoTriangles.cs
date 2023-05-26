using DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.Number.OfSystem;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.
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