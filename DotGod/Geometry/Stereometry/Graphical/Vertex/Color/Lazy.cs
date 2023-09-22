using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Color;

public sealed class Lazy : Envelope<Godot.Color>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Godot.Color>(
			new Actual(vertex))
	)
	{
	}
}