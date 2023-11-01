using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Material;

public sealed class Lazy : Envelope<Godot.Material>
{
	public Lazy(Any surface) : base
	(
		new Tumbleweed.Property.Output.Lazy<Godot.Material>(
			new Actual(surface))
	)
	{
	}
}