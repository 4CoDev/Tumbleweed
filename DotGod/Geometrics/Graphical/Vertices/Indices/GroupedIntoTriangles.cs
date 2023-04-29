using DotGod.Geometrics.Graphical.Polygons.Triangles.Numeric.OfSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;

namespace DotGod.Geometrics.Graphical.Vertices.
	Indices;

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