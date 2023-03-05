using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.
	FromSurface;

public sealed class VertexIndicesOfTriangle
	: EnumerableEnvelope<IScalar<Int32>>
{
	public VertexIndicesOfTriangle
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> triangle
	) : base
	(
		new FromIndices.VertexIndicesOfTriangle(
			new VertexIndicesOfSurface(mesh, surface), triangle)
	)
	{
	}
}