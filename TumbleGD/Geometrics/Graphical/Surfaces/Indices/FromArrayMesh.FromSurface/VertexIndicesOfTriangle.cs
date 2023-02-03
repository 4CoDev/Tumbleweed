using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.Indices.FromArrayMesh.
	FromSurface;

public sealed class VertexIndicesOfTriangle
	: EnumerableEnvelope<IScalar<int>>
{
	public VertexIndicesOfTriangle
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface,
		IScalar<int> triangle
	) : base
	(
		new FromIndices.VertexIndicesOfTriangle(
			new VertexIndicesOfSurface(mesh, surface), triangle)
	)
	{
	}
}