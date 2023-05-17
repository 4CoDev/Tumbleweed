using DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.Numeric.OfSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;

namespace DotGod.Geometry.Spatial.Graphical.Vertices.
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