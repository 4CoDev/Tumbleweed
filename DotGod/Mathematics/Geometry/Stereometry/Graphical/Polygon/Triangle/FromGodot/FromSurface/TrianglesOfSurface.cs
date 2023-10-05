using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesOfSurface
	: Tumbleweed.Enumerable.Envelope<Any>
{
	public TrianglesOfSurface
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new Enumerable(mesh, surface))
	)
	{
	}
}