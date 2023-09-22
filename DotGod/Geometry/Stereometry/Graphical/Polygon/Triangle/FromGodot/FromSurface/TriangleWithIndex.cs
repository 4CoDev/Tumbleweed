using DotGod.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Vertex.Enumerable;

namespace DotGod.Geometry.Stereometry.Graphical.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithIndex : Tumbleweed.Enumerable.Envelope<Graphical.Vertex.Any>
{
	public TriangleWithIndex
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> triangle
	) : base
	(
		new Enumerable(
			mesh,
			surface,
			new One(mesh, surface, triangle))
	)
	{
	}
}