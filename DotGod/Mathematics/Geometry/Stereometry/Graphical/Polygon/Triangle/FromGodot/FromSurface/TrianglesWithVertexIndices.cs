using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesWithVertexIndices
	: Tumbleweed.Enumerable.Envelope<Any>
{
	public TrianglesWithVertexIndices
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<IEnumerable<Int32>> triangles
	) : base
	(
		new Selected<IEnumerable<Int32>, Any>(
			triangles,
			vertices => Expression(mesh, surface, vertices))
	)
	{
	}

	private static Any Expression
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<Int32> vertices
	) =>
	(
		new TriangleWithVertexIndices(mesh, surface, vertices)
	);
}