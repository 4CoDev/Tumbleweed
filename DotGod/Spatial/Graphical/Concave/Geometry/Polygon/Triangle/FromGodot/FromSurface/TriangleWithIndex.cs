using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromArrayMesh.FromSurface;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithIndex : EnumerableEnvelope<IVertex>
{
	public TriangleWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> triangle
	) : base
	(
		new VerticesWithIndices(
			mesh,
			surface,
			new IndicesOfTriangle(mesh, surface, triangle))
	)
	{
	}
}