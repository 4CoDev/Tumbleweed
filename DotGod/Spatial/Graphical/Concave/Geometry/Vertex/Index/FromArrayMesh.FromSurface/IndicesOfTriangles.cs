using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface;

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