using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices.Indices.FromArrayMesh.
	FromSurface;

public sealed class IndicesOfTriangle
	: EnumerableEnvelope<Int32>
{
	public IndicesOfTriangle
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> triangle
	) : base
	(
		new Indices.IndicesOfTriangle(
			new IndicesOfSurface(mesh, surface), triangle)
	)
	{
	}
}