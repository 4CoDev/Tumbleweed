using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesWithVertexIndices
	: Tumbleweed.Enumerable.Envelope<IPolygon>
{
	public TrianglesWithVertexIndices
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<IEnumerable<Int32>> triangles
	) : base
	(
		new Selected<IEnumerable<Int32>, IPolygon>(
			triangles,
			vertices => Expression(mesh, surface, vertices))
	)
	{
	}

	private static IPolygon Expression
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<Int32> vertices
	) =>
	(
		new TriangleWithVertexIndices(mesh, surface, vertices)
	);
}