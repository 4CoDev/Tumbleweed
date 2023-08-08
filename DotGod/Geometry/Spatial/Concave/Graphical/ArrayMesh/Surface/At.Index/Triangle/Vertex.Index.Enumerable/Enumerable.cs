using DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Index.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.Triangle.Vertex.Index.Enumerable;

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
			new Graphical.ArrayMesh.Surface.At.Index.Vertex.Index.Enumerable(mesh, surface))
	)
	{
	}
}