using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.
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