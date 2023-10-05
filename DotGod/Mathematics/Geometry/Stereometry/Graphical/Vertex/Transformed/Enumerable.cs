using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Transformed;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable
	(
		IEnumerable<Any> vertices,
		Any<Transform3D> transform
	) : base
	(
		new Selected<Any>(
			vertices,
			vertex => new One(vertex, transform))
	)
	{
	}
}
