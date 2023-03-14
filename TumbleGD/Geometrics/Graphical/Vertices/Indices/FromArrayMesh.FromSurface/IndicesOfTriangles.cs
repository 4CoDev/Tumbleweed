using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;

public sealed class IndicesOfTriangles
	: EnumerableEnvelope<IEnumerable<Int32>>
{
	public IndicesOfTriangles
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new GroupedIntoTriangles(
			new IndicesOfSurface(mesh, surface))
	)
	{
	}
}