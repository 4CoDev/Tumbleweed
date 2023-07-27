using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.
	FromSurface;

public sealed class IndicesOfTriangle
	: Tumbleweed.Enumerable.Envelope<Int32>
{
	public IndicesOfTriangle
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> triangle
	) : base
	(
		new Index.IndicesOfTriangle(
			new IndicesOfSurface(mesh, surface), triangle)
	)
	{
	}
}