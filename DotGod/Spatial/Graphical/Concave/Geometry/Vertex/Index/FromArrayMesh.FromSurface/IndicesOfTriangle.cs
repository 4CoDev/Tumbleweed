using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.
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
		new Index.IndicesOfTriangle(
			new IndicesOfSurface(mesh, surface), triangle)
	)
	{
	}
}