using DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable;
using DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.Vertex.Enumerable;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithIndex : Tumbleweed.Enumerable.Envelope<Vertex::Any>
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