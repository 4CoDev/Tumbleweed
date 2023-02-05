using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;

public sealed class VertexIndicesOfTriangles
	: EnumerableEnvelope<IEnumerable<IScalar<int>>>
{
	public VertexIndicesOfTriangles
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	) : base
	(
		new FromIndices.VertexIndicesOfTriangles(
			new VertexIndicesOfSurface(mesh, surface))
	)
	{
	}
}