using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Index.Enumerable;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable;

public sealed class Enumerable
	: Tumbleweed.Enumerable.Envelope<IEnumerable<Int32>>
{
	public Enumerable
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new GroupedIntoTriangles(
			new At.Index.Vertex.Index.Enumerable(mesh, surface))
	)
	{
	}
}