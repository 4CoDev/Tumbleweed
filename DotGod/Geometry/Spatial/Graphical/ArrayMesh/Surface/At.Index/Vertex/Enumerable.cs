using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.ArrayMesh.Surface.At.Index.
	Vertex;

public sealed class Enumerable
	: Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<Int32> indices
	) : base
	(
		new Selected<Int32, Any>(
			indices,
			index => new One(mesh, surface, index))
	)
	{
	}
}