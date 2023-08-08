using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.
	Enumerable;

public sealed class One
	: Tumbleweed.Enumerable.Envelope<Int32>
{
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> triangle
	) : base
	(
		new Graphical.Vertex.Index.Enumerable.IndicesOfTriangle(
			new Graphical.ArrayMesh.Surface.At.Index.Vertex.Index.Enumerable(mesh, surface), triangle)
	)
	{
	}
}