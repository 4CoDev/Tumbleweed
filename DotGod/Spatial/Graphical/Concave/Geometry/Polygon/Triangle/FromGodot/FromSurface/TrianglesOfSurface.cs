using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;
using VertexIndicesOfTriangles =
	DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface.IndicesOfTriangles;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesOfSurface
	: Tumbleweed.Enumerable.Envelope<IPolygon>
{
	public TrianglesOfSurface
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangles(mesh, surface))
	)
	{
	}
}