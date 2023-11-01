using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Index.Enumerable;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.
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
		new IndicesOfTriangle(
			new At.Index.Vertex.Index.Enumerable(mesh, surface), triangle)
	)
	{
	}
}