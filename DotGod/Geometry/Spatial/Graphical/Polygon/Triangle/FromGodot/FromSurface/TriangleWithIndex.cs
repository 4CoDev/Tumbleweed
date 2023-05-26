using DotGod.Geometry.Spatial.Graphical.Vertex;
using DotGod.Geometry.Spatial.Graphical.Vertex.FromArrayMesh.FromSurface;
using DotGod.Geometry.Spatial.Graphical.Vertex.Index.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.FromGodot.FromSurface;

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