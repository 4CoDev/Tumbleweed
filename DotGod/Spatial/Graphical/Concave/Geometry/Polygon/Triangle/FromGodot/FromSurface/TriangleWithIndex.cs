using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromArrayMesh.FromSurface;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithIndex : Tumbleweed.Enumerable.Envelope<IVertex>
{
	public TriangleWithIndex
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> triangle
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