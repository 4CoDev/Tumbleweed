using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface;

public sealed class IndicesOfTriangles
	: Tumbleweed.Enumerable.Envelope<IEnumerable<Int32>>
{
	public IndicesOfTriangles
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new GroupedIntoTriangles(
			new IndicesOfSurface(mesh, surface))
	)
	{
	}
}