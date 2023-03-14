using TumbleGD.Geometrics.Graphical.Polygons.Triangles.Numeric.OfSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.
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