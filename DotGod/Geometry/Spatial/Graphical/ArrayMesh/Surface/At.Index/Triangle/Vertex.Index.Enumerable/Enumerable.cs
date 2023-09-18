using DotGod.Geometry.Spatial.Graphical.Vertex.Index.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable;

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