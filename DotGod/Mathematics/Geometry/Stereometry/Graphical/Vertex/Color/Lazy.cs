using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Color;

public sealed class Lazy : Envelope<Godot.Color>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Property.Output.Lazy<Godot.Color>(
			new Actual(vertex))
	)
	{
	}
}